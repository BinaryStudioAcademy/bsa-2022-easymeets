import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { getDisplayDuration } from '@core/helpers/display-duration-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { colorInputs } from '@core/helpers/slot-shadow-helper';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IDuration } from '@core/models/IDuration';
import { ISaveAdvancedSettings } from '@core/models/save-availability-slot/ISaveAdvancedSettings';
import { ISaveGeneralSettings } from '@core/models/save-availability-slot/ISaveGeneralSettings';
import { UserService } from '@core/services/user.service';
import { naturalNumberRegex, textFieldRegex } from '@shared/constants/model-validation';
import { invalidCharactersMessage } from '@shared/constants/shared-messages';
import { CustomEnum } from '@shared/enums/custom-field';
import { LocationType } from '@shared/enums/locationType';
import { UnitOfTime } from '@shared/enums/unitOfTime';
import { addDays, differenceInDays } from 'date-fns';

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent extends BaseComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            size: this.slot?.size ?? this.durations[0].minutes!,
            isVisible: this.slot?.isVisible ?? false,
            color: this.slot?.color ?? Color.Cyan,
            name: this.slot?.name ?? '',
            locationType: this.slot?.locationType ?? LocationType.Office,
            meetingRoom: this.slot?.meetingRoom,
            isEnabled: this.slot?.isEnabled ?? true,
            type: SlotType.Personal,
        };
        this.advancedSettings = {
            maxNumberOfBookings: this.slot?.advancedSlotSettings?.maxNumberOfBookings ?? 1,
            frequency: this.slot?.advancedSlotSettings?.frequency ?? this.durations[0].minutes!,
            days: this.slot?.advancedSlotSettings?.days ?? 1,
            paddingMeeting: this.slot?.advancedSlotSettings?.paddingMeeting ?? this.durations[0].minutes!,
            activityType: this.slot?.advancedSlotSettings?.activityType ?? this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference:
                this.slot?.advancedSlotSettings?.minBookingMeetingDifference ?? this.durations[0].minutes!,
            startDate: this.slot?.advancedSlotSettings?.startDate ?? new Date(new Date().setHours(0, 0, 0, 0)),
        };
        this.startDate = new Date(this.advancedSettings.startDate);
        this.finishDate = addDays(this.startDate, this.advancedSettings.days);

        this.addAdvanced = Boolean(this.slot?.advancedSlotSettingsId);
        this.defineCurrentDuration(this.settings.size);
        this.defineFrequency(this.advancedSettings.frequency);
        this.definePaddings(this.advancedSettings.paddingMeeting);
        this.defineBookingDifference(this.advancedSettings.minBookingMeetingDifference);
    }

    public startDate: Date;

    public finishDate: Date;

    public slot?: IAvailabilitySlot;

    public settings: ISaveGeneralSettings;

    public advancedSettings: ISaveAdvancedSettings;

    public locations: LocationType[];

    public locationOffice = LocationType.Office;

    public slotActivityOptions: string[] = ['Days', 'Range', 'Indefinitely'];

    public ActivityType = ActivityType;

    public slotActivityOptionsEnums: ActivityType[] = [
        ActivityType.Days,
        ActivityType.Range,
        ActivityType.Indefinitely,
    ];

    public addAdvanced: boolean = false;

    public textFieldRegex = textFieldRegex;

    public invalidCharactersMessage = invalidCharactersMessage;

    public naturalNumberInputPattern = naturalNumberRegex;

    public durations: IDuration[] = getDisplayDuration();

    public duration: IDuration = this.durations[0];

    public frequency: IDuration = this.durations[0];

    public paddings: IDuration = this.durations[0];

    public bookingDifference: IDuration = this.durations[0];

    public customTimeShown: boolean = false;

    public customFrequencyShown: boolean = false;

    public customPaddingsShown: boolean = false;

    public customBookingDifferenceShown: boolean = false;

    public unitOfTime = Object.keys(UnitOfTime);

    public inputCustomTime: string;

    public inputCustomFrequency: string;

    public inputCustomPadding: string;

    public inputBookingDifference: string;

    @ViewChild(NgForm) public generalForm: NgForm;

    locationTypeMapping = LocationTypeMapping;

    constructor(private userService: UserService) {
        super();
    }

    ngOnInit(): void {
        this.settings = {
            size: this.durations[0].minutes!,
            isVisible: false,
            color: Color.Cyan,
            name: '',
            locationType: LocationType.Office,
            isEnabled: true,
            type: SlotType.Personal,
        };
        this.advancedSettings = {
            maxNumberOfBookings: 1,
            days: 1,
            paddingMeeting: this.durations[0].minutes!,
            activityType: this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference: this.durations[0].minutes!,
            frequency: this.durations[0].minutes!,
            startDate: new Date(),
        };

        this.initLocations();
    }

    colorInputs = colorInputs;

    colorInputChanged(color: Color) {
        this.settings.color = color;
    }

    meetingNameChanged(value: string) {
        this.settings.name = removeExcessiveSpaces(value);
    }

    onDurationChange() {
        this.customTimeShown = this.duration.time === 'Custom';
        this.updateSettings(this.duration.minutes!, CustomEnum.Duration);
    }

    onFrequencyChange() {
        this.customFrequencyShown = this.frequency.time === 'Custom';
        this.updateSettings(this.frequency.minutes!, CustomEnum.Frequency);
    }

    onPaddingsChange() {
        this.customPaddingsShown = this.paddings.time === 'Custom';
        this.updateSettings(this.paddings.minutes!, CustomEnum.Padding);
    }

    onBookingDifferenceChange() {
        this.customBookingDifferenceShown = this.bookingDifference.time === 'Custom';
        this.updateSettings(this.bookingDifference.minutes!, CustomEnum.Book);
    }

    customDurationChanged(value: number) {
        this.updateSettings(value, CustomEnum.Duration);
    }

    customFrequencyChanged(value: number) {
        this.updateSettings(value, CustomEnum.Frequency);
    }

    customPaddingChanged(value: number) {
        this.updateSettings(value, CustomEnum.Padding);
    }

    customBookingDifferenceChanged(value: number) {
        this.updateSettings(value, CustomEnum.Book);
    }

    saveRange() {
        this.advancedSettings = {
            ...this.advancedSettings,
            startDate: new Date(this.startDate.setHours(0, 0, 0, 0)),
            days: differenceInDays(this.finishDate, this.startDate),
        };
    }

    changeFinishDate() {
        this.finishDate = addDays(this.startDate, this.advancedSettings.days);
    }

    private initLocations() {
        this.userService
            .getUserMeetIntegrations()
            .pipe(this.untilThis)
            .subscribe((locations) => {
                this.locations = locations.concat(LocationType.Office);
            });
    }

    private defineCurrentDuration(slotDuration: number) {
        this.duration =
            this.durations.find((x) => x.minutes === slotDuration) ?? this.durations.find((x) => x.time === 'Custom')!;

        if (this.duration.time === 'Custom') {
            this.customTimeShown = true;
            this.inputCustomTime = String(slotDuration);
        }
    }

    private defineFrequency(frequency: number) {
        this.frequency =
            this.durations.find((x) => x.minutes === frequency) ?? this.durations.find((x) => x.time === 'Custom')!;

        if (this.frequency.time === 'Custom') {
            this.customFrequencyShown = true;
            this.inputCustomFrequency = String(frequency);
        }
    }

    private definePaddings(paddings: number) {
        this.paddings =
            this.durations.find((x) => x.minutes === paddings) ?? this.durations.find((x) => x.time === 'Custom')!;

        if (this.paddings.time === 'Custom') {
            this.customPaddingsShown = true;
            this.inputCustomPadding = String(paddings);
        }
    }

    private defineBookingDifference(difference: number) {
        this.bookingDifference =
            this.durations.find((x) => x.minutes === difference) ?? this.durations.find((x) => x.time === 'Custom')!;

        if (this.bookingDifference.time === 'Custom') {
            this.customBookingDifferenceShown = true;
            this.inputBookingDifference = String(difference);
        }
    }

    private updateSettings(value: number, type: CustomEnum) {
        switch (type) {
            case CustomEnum.Duration:
                this.settings = {
                    ...this.settings,
                    size: value,
                };
                break;
            case CustomEnum.Frequency:
                this.advancedSettings = {
                    ...this.advancedSettings,
                    frequency: value,
                };
                break;
            case CustomEnum.Padding:
                this.advancedSettings = {
                    ...this.advancedSettings,
                    paddingMeeting: value,
                };
                break;
            case CustomEnum.Book:
                this.advancedSettings = {
                    ...this.advancedSettings,
                    minBookingMeetingDifference: value,
                };
                break;
            default:
                break;
        }
    }
}
