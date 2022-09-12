import { Component, EventEmitter, Input, Output } from '@angular/core';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IExternalAvailabilitySlot } from '@core/models/IExternalAvailabilitySlot';
import { LocationType } from '@shared/enums/locationType';

@Component({
    selector: 'app-external-booking-choose-meeting-page',
    templateUrl: './external-booking-choose-meeting-page.component.html',
    styleUrls: ['./external-booking-choose-meeting-page.component.sass'],
})
export class ExternalBookingMeetingComponent {
    @Input() personalSlots?: IExternalAvailabilitySlot[];

    @Output() setTeamId = new EventEmitter<bigint>();

    locationTypeOffice = LocationType.Office;

    locationTypeMapping = LocationTypeMapping;
}
