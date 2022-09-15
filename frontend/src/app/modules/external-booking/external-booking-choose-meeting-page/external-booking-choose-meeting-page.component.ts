import { Component, EventEmitter, Input, Output } from '@angular/core';
import { IExternalBookingSideMenu } from '@core/models/IExtendBookingSideMenu';
import { IExternalAvailabilitySlot } from '@core/models/IExternalAvailabilitySlot';

@Component({
    selector: 'app-external-booking-choose-meeting-page',
    templateUrl: './external-booking-choose-meeting-page.component.html',
    styleUrls: ['./external-booking-choose-meeting-page.component.sass'],
})
export class ExternalBookingMeetingComponent {
    @Input() menu: IExternalBookingSideMenu;

    @Input() slots?: IExternalAvailabilitySlot[];

    @Output() setTeamId = new EventEmitter<bigint>();
}
