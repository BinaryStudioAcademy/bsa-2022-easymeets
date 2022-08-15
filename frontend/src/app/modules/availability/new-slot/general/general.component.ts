import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IGeneralAvailabilitySettings } from '@core/models/IGeneralAvailabilitySettings';
import { IAvailabilitySlot } from "@core/models/IAvailiabilitySlot";
import { Subscription } from "rxjs";

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            slotSize: this.slot?.size.toString() ?? this.slotSizes[0],
            slotFrequency: this.slotsFrequencies[0],
            hideFromCommon: this.slot ? !this.slot.isVisible : false,
            maxBookings: 1,
            meetingName: this.slot?.name ?? '',
            slotActivityValue: '',
            meetingLocation: this.slot?.locationName ?? this.meetingLocations[0],
            meetingPadding: this.meetingPaddings[0],
            slotActivityOption: this.slotActivityOptions[0],
            minBookingMeetingDifference: this.minBookingMeetingDifferences[0],
        };
    }

    public slot?: IAvailabilitySlot;

    public settings: IGeneralAvailabilitySettings;

    public slotSizes: string[] = ['30 min', '60 min'];

    public slotsFrequencies: string[] = ['30 min', '60 min'];

    public meetingLocations: string[] = ['Google Meet', 'Zoom'];

    public meetingPaddings: string[] = ['15 min', '30 min'];

    public slotActivityOptions: string[] = ['Days', 'Range', 'Indefinitely'];

    public minBookingMeetingDifferences: string[] = ['2 hours', '4 hours'];

    public addAdvanced: boolean = true;

    ngOnInit(): void {
        this.settings = {
            hideFromCommon: false,
            maxBookings: 1,
            meetingName: '',
            slotActivityValue: '',
            slotSize: this.slotSizes[0],
            slotFrequency: this.slotsFrequencies[0],
            meetingLocation: this.meetingLocations[0],
            meetingPadding: this.meetingPaddings[0],
            slotActivityOption: this.slotActivityOptions[0],
            minBookingMeetingDifference: this.minBookingMeetingDifferences[0],
        };
    }
}
