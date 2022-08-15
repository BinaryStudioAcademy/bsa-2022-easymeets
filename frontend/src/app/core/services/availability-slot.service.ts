import { Injectable } from '@angular/core';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class AvailabilitySlotService {
    public routePrefix = '/availability';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getUserPersonalAndTeamSlots(currentUserId: number) {
        return this.httpService.getRequest<IUserPersonalAndTeamSlots>(`${this.routePrefix}/${currentUserId}`);
    }
}
