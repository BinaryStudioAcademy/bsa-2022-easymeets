import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSelect } from '@angular/material/select';
import { BaseComponent } from '@core/base/base.component';
import { getDisplayDate } from '@core/helpers/date-helper';
import { getDisplayDuration } from '@core/helpers/display-duration-hepler';
import { INewMeetingTeamMember } from '@core/models/INewMeetingTeamMember';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { naturalNumberRegex, newMeetingNameRegex } from '@shared/constants/model-validation';
import { LocationType } from '@shared/enums/locationType';
import { ReplaySubject } from 'rxjs';

@Component({
    selector: 'app-new-meeting',
    templateUrl: './new-meeting.component.html',
    styleUrls: ['./new-meeting.component.sass'],
})
export class NewMeetingComponent extends BaseComponent implements OnInit {
    @ViewChild('singleSelect', { static: true }) singleSelect: MatSelect;

    public teamMembers: INewMeetingTeamMember[];

    public filteredMembers: ReplaySubject<INewMeetingTeamMember[]> = new ReplaySubject<INewMeetingTeamMember[]>(1);

    public addedMembers: INewMeetingTeamMember[] = [];

    public durations = getDisplayDuration();

    public dates = getDisplayDate();

    public locations = Object.keys(LocationType).filter(key => Number.isNaN(Number(key)));

    public durationValue: string;

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

    // eslint-disable-next-line no-unused-vars
    constructor(private newMeetingService: NewMeetingService) {
        super();
        this.getTeamMembersOfCurrentUser();
    }

    ngOnInit(): void {
        this.meetingForm = new FormGroup({
            meetingName: this.meetingNameControl,
            customTime: this.customTimeControl,
            unitOfTime: new FormControl(),
            location: new FormControl(),
            duration: new FormControl(),
            mainPageDuration: new FormControl(),
            teamMember: new FormControl(),
        });
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

    public changeDuration(form: FormGroup) {
        this.durationValue = form.value.duration;
        if (this.durationValue === 'Custom') {
            this.customTimeShown = true;
        } else {
            this.customTimeShown = false;
        }
    }

    public addMemberToList(form: FormGroup) {
        this.addedMembers.push({ id: form.value.teamMember.id, name: form.value.teamMember.name });
    }
}
