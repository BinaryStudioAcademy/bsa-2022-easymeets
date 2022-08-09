import { Component } from '@angular/core';

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent {
    public slotSizes: string[] = ['30 min', '60 min'];

    public selectedSlotSize: string = this.slotSizes[0];

    public slotsFrequencies: string[] = ['30 min', '60 min'];

    public selectedFrequency: string = this.slotsFrequencies[0];

    public meetingLocations: string[] = ['Google Meet', 'Zoom'];

    public selectedLocation: string = this.meetingLocations[0];

    public meetingPaddings: string[] = ['15 min', '30 min'];

    public selectedMeetingPadding: string = this.meetingPaddings[0];

    public slotActivityOptions: string[] = ['Days', 'Range', 'Indefinitely'];

    public selectedSlotActivity: string = this.slotActivityOptions[0];

    public slotActivityValue: string;

    public meetingName: string;

    public maxBookings: number;

    public minBookingMeetingDifferences: string[] = ['2 hours', '4 hours'];

    public selectedBookingMeetingDifference: string = this.minBookingMeetingDifferences[0];

    public addAdvanced: boolean = true;
}
