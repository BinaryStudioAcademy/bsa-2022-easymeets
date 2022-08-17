import { Injectable } from '@angular/core';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';

import { HttpInternalService } from './http-internal.service';
import { IUpdateAvailability } from "@core/models/IUpdateAvailability";
import { IAvailabilitySlot } from "@core/models/IAvailiabilitySlot";

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

    public deleteSlot(slotId: bigint | undefined) {
        return this.httpService.deleteRequest<null>(`${this.routePrefix}/${slotId}`);
    }

    public updateSlot(updateAvailability: IUpdateAvailability, slotId: bigint | undefined) {
        return this.httpService.putRequest<IAvailabilitySlot>(`/availability/${slotId}`, updateAvailability)
    }

    public getSlotById(slotId: bigint | undefined) {
        return this.httpService.getRequest<IAvailabilitySlot>(`/availability/slot/${slotId}`)
    }
}
