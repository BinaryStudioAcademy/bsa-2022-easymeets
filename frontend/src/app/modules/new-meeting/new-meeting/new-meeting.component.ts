import { Component, EventEmitter, Input, OnDestroy, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { getDisplayDuration } from '@core/helpers/display-duration-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { convertDateToUTCUsingCustomTimeZone, getCurrentDate, getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IDuration } from '@core/models/IDuration';
import { IMeeting } from '@core/models/IMeeting';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { IUnavailability } from '@core/models/IUnavailability';
import { IUpdateMeeting } from '@core/models/IUpdateMeeting';
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
import { CalendarEvent } from 'angular-calendar';
import addMinutes from 'date-fns/addMinutes';
import { debounceTime, map, Observable, of, Subscription, switchMap } from 'rxjs';

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
    }

    @Input() isEditing: boolean = false;

    @Input() meetingToEdit: IMeeting;

    currentTeamId?: number;

    date: Date = getCurrentDate();

    userId: bigint | undefined;

    currentMemberId: bigint | undefined;

    addedMembers: INewMeetingMember[] = [];

    memberUnavailability: IUnavailability[] = [];

    filteredOptions: Observable<INewMeetingMember[]>;

    defaultMembers: INewMeetingMember[];

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

    event: CalendarEvent;

    meetingNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(1),
        Validators.maxLength(50),
        Validators.pattern(textFieldRegex),
    ]);

    meetingRoomControl: FormControl = new FormControl('', [
        Validators.minLength(1),
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
        this.subscribeToTeamChange();
        this.subscribeToCurrentUserChange();

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

        this.subscribeToSearchTeamMembers();
        this.addCurrentTeamMemberToList(this.userId);

        [this.duration] = this.durations;
        this.patchFormValues();
        this.setValidation();

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
                timeZone: getDefaultTimeZone(),
                createdAt: new Date(),
            };

            this.newMeetingService
                .saveNewMeeting(newMeeting)
                .pipe(this.untilThis)
                .subscribe((value) => {
                    this.createdMeeting = value;
                    this.showConfirmWindow('Meeting Created !');
                    this.reset();
                });
        } else {
            this.notificationService.showErrorMessage('All fields need to be set');
            this.showConfirmWindow('Meeting Created !');
        }
    }

    subscribeToSearchTeamMembers() {
        this.memberFilterCtrl?.valueChanges.pipe(this.untilThis, debounceTime(debounceIntervalMedium)).subscribe(() => {
            this.filteredOptions = this.memberFilterCtrl.getRawValue() ? this.searchMembersByName() : of([]);
        });
    }

    edit(form: FormGroup) {
        if (this.meetingForm.valid) {
            const updateMeeting: IUpdateMeeting = {
                id: this.meetingToEdit.id,
                name: form.value.meetingName,
                teamId: this.currentTeamId,
                locationType: form.value.location,
                meetingRoom: form.value.meetingRoom,
                duration: this.duration.minutes!,
                startTime: convertDateToUTCUsingCustomTimeZone(form.value.date, getDefaultTimeZone()),
                meetingLink: form.value.meetingName.trim(),
                meetingMembers: this.addedMembers,
            };

            this.newMeetingService
                .updateMeeting(updateMeeting)
                .pipe(this.untilThis)
                .subscribe((value) => {
                    this.createdMeeting = value;
                    this.showConfirmWindow('Meeting Updated !');
                    this.reset();
                });
        }
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
        if (this.isEditing) {
            this.setForEdit();

            return;
        }

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
        this.meetingForm.controls['date'].markAsTouched();
    }

    addMemberToList(value: INewMeetingMember) {
        this.meetingForm.get('teamMember')?.setValue(value);
        if (!this.isMemberInList(value)) {
            this.addedMembers.push(value);
        }
        this.memberFilterCtrl.setValue('');

        this.memberUnavailability = this.memberUnavailability
            .concat(value.unavailabilityItems)
            .filter(
                (range) =>
                    new Date(range.start).getTime() !== this.event?.start.getTime() &&
                    new Date(range.end).getTime() !== this.event?.end?.getTime(),
            );
    }

    removeMemberToList(memberToRemove: INewMeetingMember) {
        this.addedMembers = this.addedMembers.filter((member) => member.id !== memberToRemove.id);
        this.memberUnavailability = this.memberUnavailability.filter(
            (u) => !memberToRemove.unavailabilityItems.includes(u),
        );
    }

    isMemberInList(member: INewMeetingMember) {
        return this.addedMembers.map((m) => m.id).includes(member.id);
    }

    reset() {
        this.meetingForm.reset();
        this.patchFormValues();
        this.addedMembers = [];
    }

    onWeekChange(newDate: Date) {
        this.date = newDate;
    }

    showConfirmWindow(title: string) {
        this.confirmationWindowService.openBookingDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Done',
                    onClickEvent: this.redirectEventEmitter,
                },
            ],
            title,
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

    private subscribeToTeamChange() {
        this.teamService.currentTeamEmitted$
            .pipe(
                switchMap((teamId) => {
                    this.currentTeamId = teamId;

                    return this.getDefaultTeamMembers(teamId);
                }),
                this.untilThis,
            )
            .subscribe((members) => {
                this.defaultMembers = members;
            });
    }

    private subscribeToCurrentUserChange() {
        this.userService.userChangedEvent$.pipe(this.untilThis).subscribe((resp) => {
            this.userId = resp?.id;
        });
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

    private getDefaultTeamMembers(currentTeamId: number | undefined, count: number = 10) {
        return this.newMeetingService.getTeamMembers(currentTeamId, count);
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

    private setForEdit() {
        this.date = new Date(this.meetingToEdit.meetingTime);

        this.meetingForm.patchValue({
            meetingName: this.meetingToEdit.meetingTitle,
            location: this.meetingToEdit.locationType,
            meetingRoom: this.meetingToEdit.meetingRoom,
            date: this.date,
        });

        this.setDuration(this.meetingToEdit.meetingDuration);

        this.event = {
            start: new Date(this.meetingToEdit.meetingTime),
            end: addMinutes(new Date(this.meetingToEdit.meetingTime), this.meetingToEdit.meetingDuration),
            title: `${this.duration.time} ${this.duration.unitOfTime}`,
            cssClass: 'calendar-event',
            color: { primary: 'black', secondary: 'white' },
        };

        this.addMembersForEdit();
    }

    private setDuration(minutes: number) {
        const notCustomDuration = this.durations.find((duration) => duration.minutes === minutes);

        if (notCustomDuration) {
            this.setPredefinedDuration(notCustomDuration);

            return;
        }

        this.setCustomDuration(minutes);
    }

    private setPredefinedDuration(notCustomDuration: IDuration) {
        this.meetingForm.patchValue({
            duration: notCustomDuration,
        });

        this.duration = notCustomDuration;
    }

    private setCustomDuration(minutes: number) {
        this.customTimeShown = true;

        this.duration = this.durations.find((duration) => duration.time === 'Custom') ?? { time: 'Custom' };
        this.duration.minutes = minutes;

        if (minutes % 60 === 0) {
            this.duration.unitOfTime = UnitOfTime.Hour;
            this.duration.time = `${minutes / 60}`;
        } else {
            this.duration.unitOfTime = UnitOfTime.Min;
            this.duration.time = `${minutes}`;
        }

        this.meetingForm.patchValue({
            duration: this.duration,
            customTime: this.duration.minutes,
            unitOfTime: this.duration.unitOfTime,
        });
    }

    private addMembersForEdit() {
        this.userService
            .getCurrentUser()
            .pipe(this.untilThis)
            .subscribe((currentUser) => {
                this.meetingToEdit.meetingMembers
                    .filter((member) => member.id !== currentUser.id)
                    .forEach((member) => this.addMemberToList(member));
            });
    }

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.redirectEventSubscription.unsubscribe();
    }
}
