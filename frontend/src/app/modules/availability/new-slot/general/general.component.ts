import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { getDisplayDuration } from '@core/helpers/display-duration-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IDuration } from '@core/models/IDuration';
import { ISaveAdvancedSettings } from '@core/models/save-availability-slot/ISaveAdvancedSettings';
import { ISaveGeneralSettings } from '@core/models/save-availability-slot/ISaveGeneralSettings';
import { meetingNameRegex, naturalNumberRegex } from '@shared/constants/model-validation';
import { LocationType } from '@shared/enums/locationType';
import { UnitOfTime } from '@shared/enums/unitOfTime';

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            size: this.slot?.size ?? this.durations[0].minutes!,
            isVisible: this.slot?.isVisible ?? false,
            color: this.slot?.color ?? Color.Azure,
            name: this.slot?.name ?? '',
            locationType: this.slot?.locationType ?? LocationType.Zoom,
            isEnabled: this.slot?.isEnabled ?? true,
            type: SlotType.Personal,
        };
        this.advancedSettings = {
            maxNumberOfBookings: this.slot?.advancedSlotSettings?.maxNumberOfBookings ?? 1,
            frequency: this.slot?.advancedSlotSettings?.frequency ?? this.slotsFrequencies[0],
            days: this.slot?.advancedSlotSettings?.days ?? 1,
            paddingMeeting: this.slot?.advancedSlotSettings?.paddingMeeting ?? this.meetingPaddings[0],
            activityType: this.slot?.advancedSlotSettings?.activityType ?? this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference:
                this.slot?.advancedSlotSettings?.minBookingMeetingDifference ?? this.minBookingMeetingDifferences[0],
        };

        if (!this.slotsFrequencies.some((f) => f === this.advancedSettings?.frequency)) {
            this.slotsFrequencies.push(this.advancedSettings?.frequency);
        }

        if (!this.minBookingMeetingDifferences.some((f) => f === this.advancedSettings?.minBookingMeetingDifference)) {
            this.minBookingMeetingDifferences.push(this.advancedSettings.minBookingMeetingDifference);
        }

        if (!this.meetingPaddings.some((f) => f === this.advancedSettings?.paddingMeeting)) {
            this.meetingPaddings.push(this.advancedSettings.paddingMeeting);
        }
        this.addAdvanced = Boolean(this.slot?.advancedSlotSettingsId);
        this.defineCurrentDuration(this.settings.size);
    }

    public slot?: IAvailabilitySlot;

    public settings: ISaveGeneralSettings;

    public advancedSettings: ISaveAdvancedSettings;

    public slotsFrequencies: number[] = [30, 60];

    public locations = Object.values(LocationType);

    public meetingPaddings: number[] = [15, 30];

    public slotActivityOptions: string[] = ['Days', 'Range', 'Indefinitely'];

    public ActivityType = ActivityType;

    public slotActivityOptionsEnums: ActivityType[] = [
        ActivityType.Days,
        ActivityType.Range,
        ActivityType.Indefinitely,
    ];

    public minBookingMeetingDifferences: number[] = [2, 4];

    public addAdvanced: boolean = false;

    public meetingNameInputPattern = meetingNameRegex;

    public naturalNumberInputPattern = naturalNumberRegex;

    public durations: IDuration[] = getDisplayDuration();

    public duration: IDuration = this.durations[0];

    public customTimeShown: boolean = false;

    public unitOfTime = Object.keys(UnitOfTime);

    public selectedUnit: string = this.unitOfTime[0];

    public inputCustomTime: string;

    @ViewChild(NgForm) public generalForm: NgForm;

    locationTypeMapping = LocationTypeMapping;

    ngOnInit(): void {
        this.settings = {
            size: this.durations[0].minutes!,
            isVisible: false,
            color: Color.Azure,
            name: '',
            locationType: LocationType.Zoom,
            isEnabled: true,
            type: SlotType.Personal,
        };
        this.advancedSettings = {
            maxNumberOfBookings: 1,
            days: 1,
            paddingMeeting: this.meetingPaddings[0],
            activityType: this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference: this.minBookingMeetingDifferences[0],
            frequency: this.slotsFrequencies[0],
        };
    }

    public colorInputs: { id: string; enumValue: Color }[] = [
        {
            id: 'dark-blue-color',
            enumValue: Color.Black,
        },
        {
            id: 'light-red-color',
            enumValue: Color.Red,
        },
        {
            id: 'light-green-color',
            enumValue: Color.Orange,
        },
        {
            id: 'yellow-green-color',
            enumValue: Color.Green,
        },
        {
            id: 'aqua-color',
            enumValue: Color.Azure,
        },
        {
            id: 'blue-color',
            enumValue: Color.Blue,
        },
        {
            id: 'light-purple-color',
            enumValue: Color.Purple,
        },
        {
            id: 'red-color',
            enumValue: Color.Cherry,
        },
    ];

    colorInputChanged(color: Color) {
        this.settings.color = color;
    }

    onDurationChange() {
        this.customTimeShown = this.duration.time === 'Custom';
        this.settings.size = this.duration.minutes!;
    }

    customDurationChanged() {
        const unitOfTime: UnitOfTime = UnitOfTime[this.selectedUnit as keyof typeof UnitOfTime];

        this.settings.size =
            unitOfTime === UnitOfTime.Hour
                ? parseInt(this.inputCustomTime, 10) * 60
                : parseInt(this.inputCustomTime, 10);
    }

    private defineCurrentDuration(slotDuration: number) {
        this.duration = this.durations.find((x) => x.minutes === slotDuration) ?? this.durations[4];

        if (this.duration.time === 'Custom') {
            this.customTimeShown = true;
            this.selectedUnit = this.unitOfTime.find((x) => x === 'Min')!;
            this.inputCustomTime = String(slotDuration);
        }
    }
}
