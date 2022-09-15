import { Injectable } from '@angular/core';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { ISaveAvailability } from '@core/models/save-availability-slot/ISaveAvailability';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { IScheduleItemReceive } from '@core/models/schedule/IScheduleItemsReceive';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class AvailabilitySlotService {
    public routePrefix = '/availability';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getUserPersonalAndTeamSlots(currentUserId: bigint, currentTeamId?: number) {
        return this.httpService.getRequest<IUserPersonalAndTeamSlots>(
            `${this.routePrefix}/${currentUserId}/${currentTeamId ?? ''}`,
        );
    }

    public deleteSlot(slotId: bigint | undefined) {
        return this.httpService.deleteRequest<null>(`${this.routePrefix}/${slotId}`);
    }

    public updateSlot(updateAvailability: ISaveAvailability, slotId: bigint | undefined) {
        return this.httpService.putRequest<IAvailabilitySlot>(`/availability/${slotId}`, updateAvailability);
    }

    public updateSlotEnabling(slotId: bigint | undefined) {
        return this.httpService.postRequest<boolean>(`${this.routePrefix}/enabling/${slotId}`, {});
    }

    public getSlotById(slotId: bigint | undefined) {
        return this.httpService.getRequest<IAvailabilitySlot>(`/availability/slot/${slotId}`);
    }

    public getSlotScheduleItems(slotId: bigint) {
        return this.httpService.getRequest<IScheduleItemReceive[]>(`/availability/slot-schedule/${slotId}`);
    }

    public createSlot(newAvailability: ISaveAvailability) {
        return this.httpService.postRequest('/availability', newAvailability);
    }

    public getByLink(link: string) {
        return this.httpService.getRequest<IAvailabilitySlot | null>(`${this.routePrefix}/byLink/${link}`);
    }

    public updateScheduleExternally(link: string, schedule: ISchedule) {
        return this.httpService.putRequest(`${this.routePrefix}/${link}/externalSchedule`, schedule);
    }

    public validateSlotLink(slotLink: string, id?: bigint) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/validateLink`, { id: id ?? '', slotLink });
    }

    public validateSlotPassword(slotLink: string, password: string) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/slotPassword`, { slotLink, password });
    }
}
