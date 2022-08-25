import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSelect } from '@angular/material/select';
import { BaseComponent } from '@core/base/base.component';
import { getDisplayDate } from '@core/helpers/date-helper';
import { getDisplayDuration } from '@core/helpers/display-duration-hepler';
import { IDuration } from '@core/models/IDuration';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingTeamMember } from '@core/models/INewMeetingTeamMember';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { NotificationService } from '@core/services/notification.service';
import { naturalNumberRegex, newMeetingNameRegex } from '@shared/constants/model-validation';
import { LocationType } from '@shared/enums/locationType';
import { UnitOfTime } from '@shared/enums/unitOfTime';
import { ReplaySubject } from 'rxjs';

@Component({
    selector: 'app-new-meeting',
    templateUrl: './new-meeting.component.html',
    styleUrls: ['./new-meeting.component.sass'],
})
export class NewMeetingComponent extends BaseComponent implements OnInit {
    constructor(private newMeetingService: NewMeetingService, public notificationService: NotificationService) {
        super();
        this.getTeamMembersOfCurrentUser();
    }

    @ViewChild('singleSelect', { static: true }) singleSelect: MatSelect;

    public teamMembers: INewMeetingTeamMember[];

    public filteredMembers: ReplaySubject<INewMeetingTeamMember[]> = new ReplaySubject<INewMeetingTeamMember[]>(1);

    public addedMembers: INewMeetingTeamMember[] = [];

    public durations: IDuration[] = getDisplayDuration();

    public dates = getDisplayDate();

    public locations = Object.keys(LocationType).filter(key => Number.isNaN(Number(key)));

    public unitOfTime = Object.keys(UnitOfTime).filter(key => Number.isNaN(Number(key)));

    public duration: number;

    public startTime: string;

    public customTimeShown: boolean = false;

    public meetingForm: FormGroup;

    public memberCtrl: FormControl = new FormControl();

    public memberFilterCtrl: FormControl = new FormControl();

    public meetingNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(newMeetingNameRegex),
    ]);

    public customTimeControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.pattern(naturalNumberRegex),
    ]);

    ngOnInit(): void {
        this.meetingForm = new FormGroup({
            meetingName: this.meetingNameControl,
            customTime: this.customTimeControl,
            unitOfTime: new FormControl(),
            location: new FormControl(),
            duration: new FormControl(),
            mainContainerDuration: new FormControl(),
            date: new FormControl(),
            teamMember: new FormControl(),
        });

        this.meetingForm.patchValue({
            location: this.locations[0],
            duration: this.durations[0],
            unitOfTime: this.unitOfTime[0],
            mainContainerDuration: this.durations[0],
        });
    }

    public create(form: FormGroup) {
        // eslint-disable-next-line no-debugger
        debugger;
        const newMeeting: INewMeeting = {
            name: form.value.meetingName,
            location: form.value.location,
            duration: this.duration,
            teamMembers: this.addedMembers,
        };

        this.newMeetingService.saveNewMeeting(newMeeting)
            .pipe(this.untilThis)
            .subscribe(() => this.notificationService.showSuccessMessage('New meeting was created successfully.'));
    }

    public filterMembers() {
        let search = this.memberFilterCtrl.value;

        if (!search) {
            this.filteredMembers.next(this.teamMembers.slice());

            return;
        }
        search = search.toLowerCase();

        this.filteredMembers.next(
            this.teamMembers.filter(member => member.name.toLowerCase().indexOf(search) > -1),
        );
    }

    public getTeamMembersOfCurrentUser() {
        this.newMeetingService
            .getTeamMembersOfCurrentUser()
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.teamMembers = resp;

                this.filteredMembers.next(this.teamMembers.slice());
                this.memberFilterCtrl.valueChanges
                    .pipe(this.untilThis)
                    .subscribe(() => {
                        this.filterMembers();
                    });
            });
    }

    public showUnshowCustomDuration(form: FormGroup) {
        const durationValue = form.value.duration;

        if (durationValue.time === 'Custom') {
            this.customTimeShown = true;
        } else {
            this.customTimeShown = false;
            this.durationChanged(durationValue.time, durationValue.unitOfTime);
        }
    }

    public customDurationChanged(form: FormGroup) {
        const { customTime, unitOfTime } = form.value;

        this.durationChanged(customTime, unitOfTime);
    }

    public durationChanged(timeValue: string, unitOfTime: string) {
        if (unitOfTime === 'hour') {
            this.convertDuration(timeValue);
        } else {
            this.duration = parseInt(timeValue, 10);
        }
    }

    public convertDuration(timeValue: string) {
        this.duration = parseInt(timeValue, 10) * 60;
    }

    public addMemberToList(form: FormGroup) {
        this.addedMembers.push({ id: form.value.teamMember.id, name: form.value.teamMember.name });
    }

    public removeMemberToList(form: FormGroup) {
        this.addedMembers = this.addedMembers.filter((member) => member.id !== form.value.teamMember.id);
    }
}
