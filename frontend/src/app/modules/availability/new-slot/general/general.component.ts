import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { colorInputs } from '@core/helpers/slot-shadow-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISaveAdvancedSettings } from '@core/models/save-availability-slot/ISaveAdvancedSettings';
import { ISaveGeneralSettings } from '@core/models/save-availability-slot/ISaveGeneralSettings';
import { meetingNameRegex, naturalNumberRegex } from '@shared/constants/model-validation';
import { LocationType } from '@shared/enums/locationType';

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            size: this.slot?.size ?? this.slotSizes[0],
            isVisible: this.slot?.isVisible ?? false,
            color: this.slot?.color ?? Color.Cyan,
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

        if (!this.slotSizes.some((f) => f === this.settings.size)) {
            this.slotSizes.push(this.settings.size);
        }

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
    }

    public slot?: IAvailabilitySlot;

    public settings: ISaveGeneralSettings;

    public advancedSettings: ISaveAdvancedSettings;

    public slotSizes: number[] = [30, 60];

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

    @ViewChild(NgForm) public generalForm: NgForm;

    locationTypeMapping = LocationTypeMapping;

    ngOnInit(): void {
        this.settings = {
            size: this.slotSizes[0],
            isVisible: false,
            color: Color.Cyan,
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

    colorInputs = colorInputs;

    colorInputChanged(color: Color) {
        this.settings.color = color;
    }
}
