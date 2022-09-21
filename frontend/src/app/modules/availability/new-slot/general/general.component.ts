import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { getDisplayDuration, getInputSettings } from '@core/helpers/display-duration-helper';
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
import { AdvancedKeys, GeneralKeys, InputFieldType } from '@shared/enums/custom-field';
import { LocationType } from '@shared/enums/locationType';
import { UnitOfTime } from '@shared/enums/unitOfTime';
import { addDays, differenceInDays, startOfDay } from 'date-fns';

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent extends BaseComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;

        const defaultMinutes = this.durations[0].minutes ?? 0;

        this.settings = {
            size: this.slot?.size ?? defaultMinutes,
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
            frequency: this.slot?.advancedSlotSettings?.frequency ?? defaultMinutes,
            days: this.slot?.advancedSlotSettings?.days ?? 1,
            paddingMeeting: this.slot?.advancedSlotSettings?.paddingMeeting ?? defaultMinutes,
            activityType: this.slot?.advancedSlotSettings?.activityType ?? this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference: this.slot?.advancedSlotSettings?.minBookingMeetingDifference ?? defaultMinutes,
            startDate: this.slot?.advancedSlotSettings?.startDate ?? startOfDay(new Date()),
        };

        this.startDate = new Date(this.advancedSettings.startDate);
        this.finishDate = addDays(this.startDate, this.advancedSettings.days);

        this.defineCurrentInputValues();
        this.defineDuration();

        this.addAdvanced = Boolean(this.slot?.advancedSlotSettingsId);
    }

    public durationKey = { inputType: InputFieldType.Duration, field: GeneralKeys.size };

    public frequencyKey = { inputType: InputFieldType.Frequency, field: AdvancedKeys.frequency };

    public paddingKey = { inputType: InputFieldType.Padding, field: AdvancedKeys.paddingMeeting };

    public minBookingKey = { inputType: InputFieldType.MinBookTime, field: AdvancedKeys.minBookingMeetingDifference };

    public keys = Object.keys(InputFieldType);

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

    public inputSettings: { [type: string]: IInputSettings } = getInputSettings();

    public inputValues: { [type: string]: number } = {};

    public durations: IDuration[] = getDisplayDuration();

    public unitOfTime = Object.keys(UnitOfTime);

    @ViewChild(NgForm) public generalForm: NgForm;

    locationTypeMapping = LocationTypeMapping;

    constructor(private userService: UserService) {
        super();
    }

    ngOnInit(): void {
        const defaultMinutes = this.durations[0].minutes ?? 0;

        this.settings = {
            size: defaultMinutes,
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
            paddingMeeting: defaultMinutes,
            activityType: this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference: defaultMinutes,
            frequency: defaultMinutes,
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

    onGeneralChange(key: InputFieldType, field: keyof typeof GeneralKeys) {
        this.inputSettings[key].isCustom = this.inputSettings[key].durationValue?.time === 'Custom';
        this.updateGeneralSettings(field, this.inputSettings[key].durationValue?.minutes ?? 0);
    }

    onAdvancedChange(key: InputFieldType, field: keyof typeof AdvancedKeys) {
        this.inputSettings[key].isCustom = this.inputSettings[key].durationValue?.time === 'Custom';
        this.updateAdvancedSettings(field, this.inputSettings[key].durationValue?.minutes ?? 0);
    }

    saveRange() {
        this.advancedSettings = {
            ...this.advancedSettings,
            startDate: startOfDay(this.startDate),
            days: differenceInDays(this.finishDate, this.startDate),
        };
    }

    changeFinishDate() {
        this.finishDate = addDays(this.startDate, this.advancedSettings.days);
    }

    updateAdvancedSettings(field: keyof typeof AdvancedKeys, value: number) {
        this.advancedSettings[field] = value;
    }

    updateGeneralSettings(field: keyof typeof GeneralKeys, value: number) {
        this.settings[field] = value;
    }

    private initLocations() {
        this.userService
            .getUserMeetIntegrations()
            .pipe(this.untilThis)
            .subscribe((locations) => {
                this.locations = locations.concat(LocationType.Office);
            });
    }

    private defineCurrentInputValues() {
        this.inputValues[InputFieldType.Duration] = this.settings.size;
        this.inputValues[InputFieldType.Frequency] = this.advancedSettings.frequency;
        this.inputValues[InputFieldType.Padding] = this.advancedSettings.paddingMeeting;
        this.inputValues[InputFieldType.MinBookTime] = this.advancedSettings.minBookingMeetingDifference;
    }

    private defineDuration() {
        this.keys.forEach((el) => {
            const duration =
                this.durations.find((x) => x.minutes === this.inputValues[this.inputSettings[el].inputType]) ??
                this.durations.find((x) => x.time === 'Custom');

            this.inputSettings[el] = {
                ...this.inputSettings[el],
                durationValue: duration,
            };

            if (duration?.time === 'Custom') {
                this.inputSettings[el] = {
                    ...this.inputSettings[el],
                    isCustom: true,
                    inputValue: String(this.inputValues[this.inputSettings[el].inputType]),
                };
            }
        });
    }
}
