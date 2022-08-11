import { Injectable } from '@angular/core';
import { TeamWithSlots } from '@core/models/team-with-slot';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class AvailabilitySlotService {
    public routePrefix = '/availability';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getAvailabilitySlotsGroupByTeams() {
        return this.httpService.getRequest<TeamWithSlots[]>(`${this.routePrefix}`);
    }
}
