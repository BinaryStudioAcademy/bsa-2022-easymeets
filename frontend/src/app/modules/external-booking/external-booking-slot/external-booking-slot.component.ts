import { Component, EventEmitter, HostBinding, Input, OnInit, Output } from '@angular/core';
import { ColorShadowMapping } from '@core/helpers/color-shadow-mapping';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IColorHex } from '@core/models/IColorHex';
import { IExternalAvailabilitySlot } from '@core/models/IExternalAvailabilitySlot';
import { LocationType } from '@shared/enums/locationType';

@Component({
    selector: 'app-external-booking-slot',
    templateUrl: './external-booking-slot.component.html',
    styleUrls: ['./external-booking-slot.component.sass'],
})
export class ExternalBookingSlotComponent implements OnInit {
    @Input() slot: IExternalAvailabilitySlot;

    @Output() setTeamId = new EventEmitter<bigint>();

    locationTypeOffice = LocationType.Office;

    locationTypeMapping = LocationTypeMapping;

    @HostBinding('style.--slotLineColor') slotLineColor = '';

    @HostBinding('style.--slotShadowColor') slotShadowColor = '';

    ngOnInit(): void {
        const slotLineColorInfo: IColorHex = ColorShadowMapping(this.slot.color);

        this.slotLineColor = slotLineColorInfo.colorHex;
        this.slotShadowColor = slotLineColorInfo.shadowHex;
    }
}
