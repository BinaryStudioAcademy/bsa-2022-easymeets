import { Component } from '@angular/core';

@Component({
    selector: 'app-general',
    templateUrl: './general.component.html',
    styleUrls: ['./general.component.sass'],
})
export class GeneralComponent {
    public slotSizes: string[] = ['30 min', '60 min'];

    public slotsFrequencies: string[] = ['30 min', '60 min'];

    public meetingLocations: string[] = ['Google Meet', 'Zoom'];

    public selectedSlotSize: string = this.slotSizes[0];

    public selectedFrequency: string = this.slotsFrequencies[0];

    public selectedLocation: string = this.meetingLocations[0];

    public meetingName: string;
}
