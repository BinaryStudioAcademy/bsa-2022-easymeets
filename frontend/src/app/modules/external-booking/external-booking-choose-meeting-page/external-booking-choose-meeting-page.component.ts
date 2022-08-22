import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { LocationTypeToLabelMapping } from '@core/helpers/location-type-label-mapping';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { LocationType } from '@core/models/locationType';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-external-booking-choose-meeting-page',
    templateUrl: './external-booking-choose-meeting-page.component.html',
    styleUrls: ['./external-booking-choose-meeting-page.component.sass'],
})
export class ExternalBookingChooseMeetingComponent extends BaseComponent implements OnInit {
    @Input() selectedUserId: number;

    public selectedUserAvailabilitySlots: IUserPersonalAndTeamSlots;

    @Output() selectedDurationAndLocationEvent = new EventEmitter<{ duration: number; location: LocationType }>();

    public LocationType = LocationType;

    public LocationTypeToLabelMapping = LocationTypeToLabelMapping;

    constructor(public spinnerService: SpinnerService, private availabilitySlotService: AvailabilitySlotService) {
        super();
    }

    ngOnInit(): void {
        this.availabilitySlotService
            .getUserPersonalAndTeamSlots(this.selectedUserId)
            .pipe(this.untilThis)
            .subscribe((slots) => {
                this.selectedUserAvailabilitySlots = slots;
            });
    }

    addDurationAndLocation(duration: number, location: LocationType) {
        this.selectedDurationAndLocationEvent.emit({ duration, location });
    }
}
