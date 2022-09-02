import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { getDisplayDuration } from '@core/helpers/display-duration-hepler';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IDuration } from '@core/models/IDuration';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { naturalNumberRegex, newMeetingNameRegex } from '@shared/constants/model-validation';
import { LocationType } from '@shared/enums/locationType';
import { UnitOfTime } from '@shared/enums/unitOfTime';
import { map, Observable, startWith } from 'rxjs';

@Component({
    selector: 'app-new-meeting',
    templateUrl: './new-meeting.component.html',
    styleUrls: ['./new-meeting.component.sass'],
})
export class NewMeetingComponent extends BaseComponent implements OnInit {
    constructor(
        private newMeetingService: NewMeetingService,
        public notificationService: NotificationService,
        private teamService: TeamService,
    ) {
        super();
    }

    teamMembers: INewMeetingMember[];

    addedMembers: INewMeetingMember[] = [];

    filteredOptions: Observable<INewMeetingMember[]>;

    durations: IDuration[] = getDisplayDuration();

    locations = Object.values(LocationType);

    unitOfTime = Object.keys(UnitOfTime);

    duration: number;

    durationValue: number;

    customTimeShown: boolean = false;

    mainContentCustomTimeShown: boolean = false;

    locationTypeMapping = LocationTypeMapping;

    meetingForm: FormGroup;

    memberFilterCtrl: FormControl = new FormControl('');

    meetingNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(newMeetingNameRegex),
    ]);

    customTimeControl: FormControl = new FormControl('', [Validators.pattern(naturalNumberRegex)]);

    mainContainerCustomTimeControl: FormControl = new FormControl('', [Validators.pattern(naturalNumberRegex)]);

    ngOnInit(): void {
        this.meetingForm = new FormGroup({
            meetingName: this.meetingNameControl,
            customTime: this.customTimeControl,
            unitOfTime: new FormControl(),
            location: new FormControl(),
            duration: new FormControl(),
            mainContainerDuration: new FormControl(),
            mainContainerCustomTime: this.mainContainerCustomTimeControl,
            mainContainerUnitOfTime: new FormControl(),
            date: new FormControl('', [Validators.required]),
            teamMember: new FormControl(),
        });
        this.patchFormValues();
        this.setValidation();

        this.teamService.currentTeamEmitted$
            .subscribe(teamId => {
                this.getTeamMembersOfCurrentUser(teamId);
            });
    }

    create(form: FormGroup) {
        if (!this.customTimeShown) {
            this.durationValue = form.value.duration.time;
        }
        if (this.meetingForm.valid) {
            const newMeeting: INewMeeting = {
                name: form.value.meetingName,
                location: form.value.location,
                duration: this.durationValue,
                startTime: form.value.date,
                meetingLink: form.value.meetingName,
                meetingMembers: this.addedMembers,
                createdAt: new Date(),
            };

            this.newMeetingService
                .saveNewMeeting(newMeeting)
                .pipe(this.untilThis)
                .subscribe(() => {
                    this.notificationService.showSuccessMessage('New meeting was created successfully.');
                    this.reset();
                });
        } else {
            this.notificationService.showErrorMessage('All fiels need to be set');
        }
    }

    getTeamMembersOfCurrentUser(teamId?: number) {
        this.newMeetingService
            .getTeamMembersOfCurrentUser(teamId)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.teamMembers = resp;
                this.getFilteredOptions();
            });
    }

    displayMemberName(teamMember: INewMeetingMember): string {
        return teamMember?.name ?? '';
    }

    setValidation() {
        if (this.meetingForm.value.duration.time === 'Custom') {
            this.meetingForm.controls['customTime'].setValidators(Validators.required);
        } else {
            this.meetingForm.controls['customTime'].clearValidators();
        }
    }

    patchFormValues() {
        this.meetingForm.patchValue({
            location: this.locations[0],
            duration: this.durations[0],
            unitOfTime: this.unitOfTime[0],
            mainContainerDuration: this.durations[0],
            mainContainerUnitOfTime: this.unitOfTime[0],
        });
    }

    showUnshowCustomDuration(form: FormGroup) {
        const durationValue = form.value.duration;

        this.customTimeShown = durationValue.time === 'Custom';
        this.mainContentCustomTimeShown = form.value.mainContainerDuration.time === 'Custom';

        if (this.customTimeShown) {
            this.setValidation();
        } else {
            this.durationChanged(durationValue.time, durationValue.unitOfTime);
        }
    }

    customDurationChanged(form: FormGroup) {
        const { customTime, unitOfTime } = form.value;

        this.durationChanged(customTime, unitOfTime);
    }

    durationChanged(timeValue: string, unitOfTime: string) {
        if (unitOfTime === 'hour') {
            this.convertDuration(timeValue);
        } else {
            this.duration = parseInt(timeValue, 10);
        }
    }

    convertDuration(timeValue: string) {
        this.duration = parseInt(timeValue, 10) * 60;
    }

    addMemberToList(value: INewMeetingMember) {
        this.meetingForm.get('teamMember')?.setValue(value);
        if (!this.addedMembers.includes(value)) {
            this.addedMembers.push(value);
        }
        this.memberFilterCtrl.setValue('');
    }

    removeMemberToList(form: FormGroup) {
        this.addedMembers = this.addedMembers.filter((member) => member.id !== form.value.teamMember.id);
    }

    reset() {
        this.meetingForm.reset();
        this.patchFormValues();
        this.addedMembers = [];
    }

    private getFilteredOptions() {
        this.filteredOptions = this.memberFilterCtrl.valueChanges.pipe(
            startWith(''),
            map(value => {
                if (typeof value === 'string') {
                    const filterValue = value.toLowerCase() || '';

                    return this.teamMembers.filter((teamMembers) => teamMembers.name.toLowerCase().includes(filterValue));
                }

                return this.teamMembers.filter((teamMembers) => teamMembers.name.toLowerCase().includes(value.name));
            }),
        );
    }
}
