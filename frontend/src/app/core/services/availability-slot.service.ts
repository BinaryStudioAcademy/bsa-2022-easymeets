import { Injectable } from '@angular/core';
import { AvailabilitySlot } from '@core/models/availiability-slot';
import { TeamWithSlots } from '@core/models/team-with-slot';
import { User } from '@core/models/user';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class AvailabilitySlotService {
    public routePrefix = '/availability';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getAvailabilitySlotsGroupByTeams(currentUserId: number) {
        return this.httpService.getRequest<TeamWithSlots[]>(`${this.routePrefix}/team/${currentUserId}`);
    }

    public getAllUsersAvailabilitySlots(currentUserId: number) {
        return this.httpService.getRequest<AvailabilitySlot[]>(`${this.routePrefix}/personal/${currentUserId}`);
    }

    public getCurrentUser(currentUserId: number) {
        return this.httpService.getRequest<User>(`/user/current/${currentUserId}`);
    }
}
