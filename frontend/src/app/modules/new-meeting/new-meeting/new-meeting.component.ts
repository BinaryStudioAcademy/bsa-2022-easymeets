import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { getDisplayDuration } from '@core/helpers/display-duration-helper';
import { IDuration } from '@core/models/IDuration';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { nameRegex, naturalNumberRegex } from '@shared/constants/model-validation';
import { LocationType } from '@shared/enums/locationType';
import { UnitOfTime } from '@shared/enums/unitOfTime';
import { map, Observable, startWith, Subscription } from 'rxjs';

@Component({
    selector: 'app-new-meeting',
    templateUrl: './new-meeting.component.html',
    styleUrls: ['./new-meeting.component.sass'],
})
export class NewMeetingComponent extends BaseComponent implements OnInit, OnDestroy {
    constructor(
        private newMeetingService: NewMeetingService,
        public notificationService: NotificationService,
        private confirmationWindowService: ConfirmationWindowService,
        private router: Router,
        private teamService: TeamService,
    ) {
        super();
        this.redirectEventSubscription = this.redirectEventEmitter.subscribe(() => this.goToBookingsPage());
    }

    date: Date = new Date();

    teamMembers: INewMeetingMember[];

    addedMembers: INewMeetingMember[] = [];

    filteredOptions: Observable<INewMeetingMember[]>;

    durations: IDuration[] = getDisplayDuration();

    locations = Object.values(LocationType);

    unitOfTime = Object.keys(UnitOfTime);

    filterValue = '';

    duration: IDuration;

    customTimeShown: boolean = false;

    meetingForm: FormGroup;

    private bookedIconPath: string = 'assets/booked-icon.png';

    memberFilterCtrl: FormControl = new FormControl('');

    meetingNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(nameRegex),
    ]);

    customTimeControl: FormControl = new FormControl('', [Validators.pattern(naturalNumberRegex)]);

    mainContainerCustomTimeControl: FormControl = new FormControl('', [Validators.pattern(naturalNumberRegex)]);

    private redirectEventEmitter = new EventEmitter<void>();

    private redirectEventSubscription: Subscription;

    createdMeeting: INewMeeting;

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

        this.teamService.currentTeamEmitted$.subscribe((teamId) => {
            this.getTeamMembersOfCurrentUser(teamId);
        });
        [this.duration] = this.durations;
    }

    create(form: FormGroup) {
        if (this.meetingForm.valid) {
            const newMeeting: INewMeeting = {
                name: form.value.meetingName,
                locationType: form.value.location,
                duration: this.duration.minutes!,
                startTime: form.value.date,
                meetingLink: form.value.meetingName,
                meetingMembers: this.addedMembers,
                createdAt: new Date(),
            };

            this.newMeetingService
                .saveNewMeeting(newMeeting)
                .pipe(this.untilThis)
                .subscribe((value) => {
                    this.createdMeeting = value;
                    this.reset();
                    this.showConfirmWindow();
                });
        } else {
            this.notificationService.showErrorMessage('All fields need to be set');
            this.showConfirmWindow();
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

        const customMinutes = unitOfTime === UnitOfTime.Hour ? parseInt(customTime, 10) * 60 : parseInt(customTime, 10);

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

    removeMemberToList(memberId: number) {
        this.addedMembers = this.addedMembers.filter((member) => member.id !== memberId);
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
                this.filterValue = typeof value === 'string' ? value.toLowerCase() : value.name;

                return this.teamMembers.filter(
                    (teamMembers) => teamMembers.name.toLowerCase().includes(this.filterValue),
                    // eslint-disable-next-line function-paren-newline
                );
            }),
        );
    }

    showConfirmWindow() {
        this.confirmationWindowService.openBookingDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Done',
                    onClickEvent: this.redirectEventEmitter,
                },
            ],
            title: 'Meeting Created !',
            titleImagePath: this.bookedIconPath,
            dateTime: this.createdMeeting.startTime,
            duration: this.duration.minutes,
            meetingName: this.createdMeeting.name,
            participants: this.addedMembers,
            location: this.createdMeeting.locationType,
            link: this.createdMeeting.meetingLink,
        });
    }

    goToBookingsPage() {
        this.router.navigate(['/bookings']);
    }

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.redirectEventSubscription.unsubscribe();
    }

    private validateDateIsInFuture(control: AbstractControl): ValidationErrors | null {
        const isDateInPast = new Date(control.value).getTime() < Date.now();

        return isDateInPast ? { invalid: true } : null;
    }
}
