import { Injectable } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { ISaveAvailability } from '@core/models/save-availability-slot/ISaveAvailability';

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

    public deleteSlot(slotId: bigint | undefined) {
        return this.httpService.deleteRequest<null>(`${this.routePrefix}/${slotId}`);
    }

    public updateSlot(updateAvailability: ISaveAvailability, slotId: bigint | undefined) {
        return this.httpService.putRequest<IAvailabilitySlot>(`/availability/${slotId}`, updateAvailability);
    }

    public getSlotById(slotId: bigint | undefined) {
        return this.httpService.getRequest<IAvailabilitySlot>(`/availability/slot/${slotId}`);
    }

    public createSlot(newAvailability: ISaveAvailability) {
        return this.httpService.postRequest('/availability', newAvailability);
    }
}
