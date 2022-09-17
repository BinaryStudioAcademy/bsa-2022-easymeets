import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { getDefaultInputSettings, getDisplayDuration } from '@core/helpers/display-duration-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { colorInputs } from '@core/helpers/slot-shadow-helper';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IDuration } from '@core/models/IDuration';
import { IInputSettings } from '@core/models/save-availability-slot/IInputSettings';
import { ISaveAdvancedSettings } from '@core/models/save-availability-slot/ISaveAdvancedSettings';
import { ISaveGeneralSettings } from '@core/models/save-availability-slot/ISaveGeneralSettings';
import { UserService } from '@core/services/user.service';
import { naturalNumberRegex, textFieldRegex } from '@shared/constants/model-validation';
import { invalidCharactersMessage } from '@shared/constants/shared-messages';
import { InputFieldType } from '@shared/enums/custom-field';
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

        this.defineCurrentInputValues();

        this.defineDuration();

        this.addAdvanced = Boolean(this.slot?.advancedSlotSettingsId);
    }

    public durationKey: number;

    public frequencyKey: number;

    public paddingKey: number;

    public minBookingKey: number;

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

    public inputSettings: IInputSettings[];

    public inputValues: { [type: string]: number } = {};

    public durations: IDuration[] = getDisplayDuration();

    public unitOfTime = Object.keys(UnitOfTime);

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
        this.inputSettings = getDefaultInputSettings();
        this.defineInputKeys();
    }

    colorInputs = colorInputs;

    colorInputChanged(color: Color) {
        this.settings.color = color;
    }

    meetingNameChanged(value: string) {
        this.settings.name = removeExcessiveSpaces(value);
    }

    onValueChange(index: number) {
        this.inputSettings[index].isCustom = this.inputSettings[index].durationValue?.time === 'Custom';
        this.updateSettings(this.inputSettings[index].durationValue?.minutes!, this.inputSettings[index].inputType);
    }

    customDurationChanged(value: number) {
        this.updateSettings(value, InputFieldType.Duration);
    }

    customFrequencyChanged(value: number) {
        this.updateSettings(value, InputFieldType.Frequency);
    }

    customPaddingChanged(value: number) {
        this.updateSettings(value, InputFieldType.Padding);
    }

    customBookingDifferenceChanged(value: number) {
        this.updateSettings(value, InputFieldType.MinBookTime);
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

    private defineInputKeys() {
        this.durationKey = this.inputSettings.indexOf(this.inputSettings.find((el) => el.inputType === InputFieldType.Duration)!);
        this.frequencyKey = this.inputSettings.indexOf(this.inputSettings.find((el) => el.inputType === InputFieldType.Frequency)!);
        this.paddingKey = this.inputSettings.indexOf(this.inputSettings.find((el) => el.inputType === InputFieldType.Padding)!);
        this.minBookingKey = this.inputSettings.indexOf(this.inputSettings.find((el) => el.inputType === InputFieldType.MinBookTime)!);
    }

    private defineCurrentInputValues() {
        this.inputValues[InputFieldType.Duration] = this.settings.size;
        this.inputValues[InputFieldType.Frequency] = this.advancedSettings.frequency;
        this.inputValues[InputFieldType.Padding] = this.advancedSettings.paddingMeeting;
        this.inputValues[InputFieldType.MinBookTime] = this.advancedSettings.minBookingMeetingDifference;
    }

    private defineDuration() {
        this.inputSettings = [
            ...this.inputSettings.map((val) => {
                val.durationValue =
                    this.durations.find((x) => x.minutes === this.inputValues[val.inputType]) ??
                    this.durations.find((x) => x.time === 'Custom')!;

                if (val.durationValue?.time === 'Custom') {
                    val.isCustom = true;
                    val.inputValue = String(this.inputValues[val.inputType]);
                }

                return val;
            }),
        ];
    }

    private updateSettings(value: number, type: InputFieldType) {
        switch (type) {
            case InputFieldType.Duration:
                this.settings = {
                    ...this.settings,
                    size: value,
                };
                break;
            case InputFieldType.Frequency:
                this.advancedSettings = {
                    ...this.advancedSettings,
                    frequency: value,
                };
                break;
            case InputFieldType.Padding:
                this.advancedSettings = {
                    ...this.advancedSettings,
                    paddingMeeting: value,
                };
                break;
            case InputFieldType.MinBookTime:
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
