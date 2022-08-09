import { Component, OnInit } from '@angular/core';
import { GeneralAvailabilitySettings } from '@core/models/generalAvailabilitySettings';

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent implements OnInit {
    public settings: GeneralAvailabilitySettings;

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
