import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { getDisplayDuration } from '@core/helpers/display-duration-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { convertDateToUTCUsingCustomTimeZone, getCurrentDate, getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IDuration } from '@core/models/IDuration';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { IUnavailability } from '@core/models/IUnavailability';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';
import { naturalNumberRegex, textFieldRegex } from '@shared/constants/model-validation';
import { debounceIntervalMedium } from '@shared/constants/rxjs-constants';
import { invalidCharactersMessage } from '@shared/constants/shared-messages';
import { LocationType } from '@shared/enums/locationType';
import { UnitOfTime } from '@shared/enums/unitOfTime';
import { debounceTime, map, Observable, of, Subscription } from 'rxjs';

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
        private userService: UserService,
    ) {
        super();
        this.redirectEventSubscription = this.redirectEventEmitter.subscribe(() => this.goToBookingsPage());

        this.teamService.currentTeamEmitted$.pipe(this.untilThis).subscribe((resp) => {
            this.currentTeamId = resp;
        });

        this.userService.userChangedEvent$.pipe(this.untilThis).subscribe((resp) => {
            this.userId = resp?.id;
        });
    }

    currentTeamId?: number;

    date: Date = getCurrentDate();

    userId: bigint | undefined;

    currentMemberId: bigint | undefined;

    addedMembers: INewMeetingMember[] = [];

    memberUnavailability: IUnavailability[] = [];

    filteredOptions: Observable<INewMeetingMember[]>;

    durations: IDuration[] = getDisplayDuration();

    locations: LocationType[] = [LocationType.Office];

    public locationOffice = LocationType.Office;

    unitOfTime = Object.keys(UnitOfTime);

    filterValue = '';

    duration: IDuration;

    customTimeShown: boolean = false;

    meetingForm: FormGroup;

    invalidCharactersMessage = invalidCharactersMessage;

    private bookedIconPath: string = 'assets/booked-icon.png';

    memberFilterCtrl: FormControl = new FormControl('');

    locationControl: FormControl = new FormControl();

    meetingNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(1),
        Validators.maxLength(50),
        Validators.pattern(textFieldRegex),
    ]);

    meetingRoomControl: FormControl = new FormControl('', [
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(textFieldRegex),
    ]);

    customTimeControl: FormControl = new FormControl('', [Validators.pattern(naturalNumberRegex)]);

    mainContainerCustomTimeControl: FormControl = new FormControl('', [Validators.pattern(naturalNumberRegex)]);

    createdMeeting: INewMeeting;

    locationTypeMapping = LocationTypeMapping;

    private redirectEventEmitter = new EventEmitter<void>();

    private redirectEventSubscription: Subscription;

    ngOnInit(): void {
        this.meetingForm = new FormGroup({
            meetingName: this.meetingNameControl,
            customTime: this.customTimeControl,
            unitOfTime: new FormControl(),
            location: this.locationControl,
            meetingRoom: this.meetingRoomControl,
            duration: new FormControl(),
            date: new FormControl('', [Validators.required, this.validateDateIsInFuture]),
            teamMember: new FormControl(),
        });
        this.patchFormValues();
        this.setValidation();

        this.subscribeToSearchTeamMembers();
        this.addCurrentTeamMemberToList(this.userId);

        [this.duration] = this.durations;
        this.initLocations();
    }

    create(form: FormGroup) {
        if (this.meetingForm.valid) {
            const newMeeting: INewMeeting = {
                name: form.value.meetingName.trim(),
                teamId: this.currentTeamId,
                locationType: form.value.location,
                meetingRoom: form.value.meetingRoom,
                duration: this.duration.minutes!,
                startTime: convertDateToUTCUsingCustomTimeZone(new Date(form.value.date), getDefaultTimeZone()),
                meetingLink: form.value.meetingName.trim(),
                meetingMembers: this.addedMembers,
                createdAt: new Date(),
            };

            this.newMeetingService
                .saveNewMeeting(newMeeting)
                .pipe(this.untilThis)
                .subscribe((value) => {
                    this.createdMeeting = value;
                    this.showConfirmWindow();
                    this.reset();
                });
        } else {
            this.notificationService.showErrorMessage('All fields need to be set');
            this.showConfirmWindow();
        }
    }

    subscribeToSearchTeamMembers() {
        this.memberFilterCtrl?.valueChanges.pipe(this.untilThis, debounceTime(debounceIntervalMedium)).subscribe(() => {
            this.filteredOptions = this.memberFilterCtrl.getRawValue() ? this.searchMembersByName() : of([]);
        });
    }

    searchMembersByName() {
        return this.newMeetingService
            .getTeamMembersByName(this.memberFilterCtrl.getRawValue(), this.currentTeamId)
            .pipe(map((resp) => resp?.filter((u) => !this.addedMembers.some((el) => el.id === u.id))));
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
        this.memberUnavailability = this.memberUnavailability.concat(value.unavailabilityItems);
    }

    removeMemberToList(memberToRemove: INewMeetingMember) {
        this.addedMembers = this.addedMembers.filter((member) => member.id !== memberToRemove.id);
        this.memberUnavailability = this.memberUnavailability.filter(
            (u) => !memberToRemove.unavailabilityItems.includes(u),
        );
    }

    reset() {
        this.meetingForm.reset();
        this.patchFormValues();
        this.addedMembers = [];
    }

    onWeekChange(newDate: Date) {
        this.date = newDate;
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
            dateTime: new Date(this.createdMeeting.startTime),
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

    trimInputValue(control: FormControl) {
        control.patchValue(removeExcessiveSpaces(control.value));
    }

    private addCurrentTeamMemberToList(userId?: bigint) {
        this.newMeetingService
            .getTeamMembersById(userId, this.currentTeamId)
            .pipe(this.untilThis)
            .subscribe((resp) => {
                this.addMemberToList(resp);

                this.currentMemberId = resp.id;
            });
    }

    private initLocations() {
        this.userService
            .getUserMeetIntegrations()
            .pipe(this.untilThis)
            .subscribe((locations) => {
                this.locations = locations.concat(LocationType.Office);
            });
    }

    private validateDateIsInFuture(control: AbstractControl): ValidationErrors | null {
        const isDateInPast = new Date(control.value).getTime() < getCurrentDate().getTime();

        return isDateInPast ? { invalid: true } : null;
    }

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.redirectEventSubscription.unsubscribe();
    }
}
