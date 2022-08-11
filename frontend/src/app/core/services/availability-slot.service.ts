import { Injectable } from '@angular/core';
import { AvailabilitySlot } from '@core/models/availiability-slot';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class AvailabilitySlotService {
    public routePrefix = '/availability';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getAvailabilitySlots() {
        return this.httpService.getRequest<AvailabilitySlot[]>(`${this.routePrefix}`);
    }
}
