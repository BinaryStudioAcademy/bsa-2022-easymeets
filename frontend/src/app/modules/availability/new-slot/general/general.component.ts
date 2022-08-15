import { Component, Input, OnInit } from '@angular/core';
import { IGeneralAvailabilitySettings } from '@core/models/IGeneralAvailabilitySettings';
import { IAvailabilitySlot } from "@core/models/IAvailiabilitySlot";
import { ActivityType } from "@core/enums/activity-type.enum";
import { Color } from "@core/enums/color.enum";

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            slotSize: this.slot?.size ?? this.slotSizes[0],
            slotFrequency: this?.slot?.frequency ?? this.slotsFrequencies[0],
            hideFromCommon: this.slot ? !this.slot.isVisible : false,
            maxBookings: this.slot?.advancedSlotSettings?.maxNumberOfBookings ?? 1,
            meetingName: this.slot?.name ?? this.meetingLocations[0],
            slotActivityValue: this.slot?.advancedSlotSettings?.days ?? 1,
            meetingLocation: this.slot?.locationName ?? this.meetingLocations[0],
            meetingPadding: this.slot?.advancedSlotSettings?.paddingMeeting ?? this.meetingPaddings[0],
            slotActivityOption: this.slot?.advancedSlotSettings?.activityType ?? this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference: this.slot?.advancedSlotSettings?.minBookingMeetingDifference ?? this.minBookingMeetingDifferences[0],
        };

        if (!this.slotSizes.some(f => f === this.settings.slotSize)) {
            this.slotSizes.push(this.settings.slotSize);
        }

        if (!this.slotsFrequencies.some(f => f === this.settings.slotFrequency)) {
            this.slotsFrequencies.push(this.settings.slotFrequency);
        }

        if (!this.minBookingMeetingDifferences.some(f => f === this.settings.minBookingMeetingDifference)) {
            this.minBookingMeetingDifferences.push(this.settings.minBookingMeetingDifference);
        }

        if (!this.meetingPaddings.some(f => f === this.settings.meetingPadding)) {
            this.meetingPaddings.push(this.settings.meetingPadding);
        }

        this.addAdvanced = Boolean(this.slot?.advancedSlotSettingsId);

        console.log(this.settings);
        console.log(this.slot?.advancedSlotSettings);
    }

    public slot?: IAvailabilitySlot;

    public settings: IGeneralAvailabilitySettings;

    public slotSizes: number[] = [30, 60];

    public slotsFrequencies: number[] = [30, 60];

    public meetingLocations: string[] = ['Google Meet', 'Zoom'];

    public meetingPaddings: number[] = [15, 30];

    public slotActivityOptions: string[] = ['Days', 'Range', 'Indefinitely'];

    public slotActivityOptionsEnums: ActivityType[] = [ActivityType.Days, ActivityType.Range, ActivityType.Indefinitely];

    public minBookingMeetingDifferences: number[] = [2, 4];

    public addAdvanced: boolean = false;

    ngOnInit(): void {
        this.settings = {
            hideFromCommon: false,
            maxBookings: 1,
            meetingName: '',
            slotActivityValue: 1,
            slotSize: this.slotSizes[0],
            slotFrequency: this.slotsFrequencies[0],
            meetingLocation: this.meetingLocations[0],
            meetingPadding: this.meetingPaddings[0],
            slotActivityOption: this.slotActivityOptionsEnums[0],
            minBookingMeetingDifference: this.minBookingMeetingDifferences[0],
        };
    }

    public colorInputs: {id: string; enumValue: Color}[] = [
        {
            id: "dark-blue-color",
            enumValue: Color.Blue
        },
        {
            id: "light-red-color",
            enumValue: Color.Red
        },
        {
            id: "light-green-color",
            enumValue: Color.Orange
        },
        {
            id: "yellow-green-color",
            enumValue: Color.Green
        },
        {
            id: "aqua-color",
            enumValue: Color.Azure
        },
        {
            id: "blue-color",
            enumValue: Color.Blue
        },
        {
            id: "light-purple-color",
            enumValue: Color.Purple
        },
        {
            id: "red-color",
            enumValue: Color.Cherry
        }
    ]
}
