import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { getDisplayDuration } from '@core/helpers/display-duration-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IDuration } from '@core/models/IDuration';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { NotificationService } from '@core/services/notification.service';
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
    constructor(private newMeetingService: NewMeetingService, public notificationService: NotificationService) {
        super();
    }

    date: Date = new Date();

    teamMembers: INewMeetingMember[];

    addedMembers: INewMeetingMember[] = [];

    filteredOptions: Observable<INewMeetingMember[]>;

    durations: IDuration[] = getDisplayDuration();

    locations = Object.values(LocationType);

    unitOfTime = Object.keys(UnitOfTime);

    duration: IDuration;

    durationValue: number;

    customTimeShown: boolean = false;

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
            date: new FormControl('', [Validators.required, this.validateDateIsInFuture]),
            teamMember: new FormControl(),
        });
        this.patchFormValues();
        this.setValidation();
        this.getTeamMembersOfCurrentUser();
        [this.duration] = this.durations;
    }

    create(form: FormGroup) {
        if (this.meetingForm.valid) {
            const newMeeting: INewMeeting = {
                name: form.value.meetingName,
                location: form.value.location,
                duration: this.duration.minutes!,
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
            this.notificationService.showErrorMessage('All fields need to be set');
        }
    }

    getTeamMembersOfCurrentUser() {
        this.newMeetingService
            .getTeamMembersOfCurrentUser()
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

    onDurationChange(form: FormGroup) {
        this.duration = form.value.duration;

        this.customTimeShown = this.duration.time === 'Custom';

        if (this.customTimeShown) {
            this.setValidation();
        } else {
            this.meetingForm.controls['customTime'].setValue('');
        }
    }

    customDurationChanged(form: FormGroup) {
        const { customTime } = form.value;

        const unitOfTime: UnitOfTime = form.controls['unitOfTime'].value;
        let customMinutes: number;

        if (unitOfTime === UnitOfTime.Hour) {
            customMinutes = parseInt(customTime, 10) * 60;
        } else {
            customMinutes = parseInt(customTime, 10);
        }

        this.duration = { time: customTime, unitOfTime: UnitOfTime[unitOfTime], minutes: customMinutes };
    }

    onMeetingStartChange(startDate: Date) {
        this.meetingForm.patchValue({
            date: startDate,
        });
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

    onWeekChange(newDate: Date) {
        this.date = newDate;
    }

    private getFilteredOptions() {
        this.filteredOptions = this.memberFilterCtrl.valueChanges.pipe(
            startWith(''),
            map((value) => {
                const filterValue = value.toLowerCase() || '';

                return this.teamMembers.filter((teamMembers) => teamMembers.name.toLowerCase().includes(filterValue));
            }),
        );
    }

    private validateDateIsInFuture(control: AbstractControl): ValidationErrors | null {
        const isDateInPast = new Date(control.value).getTime() < Date.now();

        return isDateInPast ? { invalid: true } : null;
    }
}
