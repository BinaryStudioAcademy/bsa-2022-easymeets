import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivityType } from '@core/enums/activity-type.enum';
import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { LocationTypeToLabelMapping } from '@core/helpers/location-type-label-mapping';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { LocationType } from '@core/models/locationType';
import { ISaveAdvancedSettings } from '@core/models/save-availability-slot/ISaveAdvancedSettings';
import { ISaveGeneralSettings } from '@core/models/save-availability-slot/ISaveGeneralSettings';

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
            frequency: this?.slot?.frequency ?? this.slotsFrequencies[0],
            isVisible: this.slot ? !this.slot.isVisible : false,
            name: this.slot?.name ?? '',
            locationType: this.slot?.locationType ?? LocationType.Zoom,
            isEnabled: this.slot?.isEnabled ?? true,
            type: SlotType.Personal,
        };
        this.advancedSettings = {
            maxNumberOfBookings: this.slot?.advancedSlotSettings?.maxNumberOfBookings ?? 1,
            days: this.slot?.advancedSlotSettings?.days ?? 1,
            paddingMeeting: this.slot?.advancedSlotSettings?.paddingMeeting ?? this.meetingPaddings[0],
            activityType: this.slot?.advancedSlotSettings?.activityType ?? this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference:
                this.slot?.advancedSlotSettings?.minBookingMeetingDifference ?? this.minBookingMeetingDifferences[0],
            color: this.slot?.advancedSlotSettings?.color ?? Color.Azure,
        };

        if (!this.slotSizes.some((f) => f === this.settings.size)) {
            this.slotSizes.push(this.settings.size);
        }

        if (!this.slotsFrequencies.some((f) => f === this.settings.frequency)) {
            this.slotsFrequencies.push(this.settings.frequency);
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

    public LocationTypeToLabelMapping = LocationTypeToLabelMapping;

    public locationTypes: LocationType[] = [LocationType.Zoom, LocationType.GoogleMeet, LocationType.Office];

    public meetingPaddings: number[] = [15, 30];

    public slotActivityOptions: string[] = ['Days', 'Range', 'Indefinitely'];

    public slotActivityOptionsEnums: ActivityType[] = [
        ActivityType.Days,
        ActivityType.Range,
        ActivityType.Indefinitely,
    ];

    public minBookingMeetingDifferences: number[] = [2, 4];

    public addAdvanced: boolean = false;

    public meetingNameInputPattern = "^[A-Za-z0-9-']*$";

    public naturalNumberInputPattern = '^[1-9][0-9]*$';

    @ViewChild(NgForm) public generalForm: NgForm;

    ngOnInit(): void {
        this.settings = {
            size: this.slotSizes[0],
            frequency: this.slotsFrequencies[0],
            isVisible: false,
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
            color: Color.Azure,
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
        this.advancedSettings!.color = color;
    }
}
