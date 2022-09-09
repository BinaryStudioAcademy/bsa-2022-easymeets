import { Injectable } from '@angular/core';
import { IExternalAttendeeBookingInfo } from '@core/models/IExternalAttendeeBookingInfo';
import { IExternalAttendeeMeeting } from '@core/models/IExternalAttendeeMeeting';
import { IExternalUser } from '@core/models/IExternalUser';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class ExternalAttendeeService {
    public routePrefix = '/externalattendee';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public createExternalMeeting(externalMeeting: IExternalAttendeeMeeting) {
        return this.httpService.postRequest(`${this.routePrefix}`, externalMeeting);
    }

    public getUserAndPersonalSlots(personalUrl: string) {
        return this.httpService.getRequest<IExternalAttendeeBookingInfo>(
            `${this.routePrefix}/personal-slots/${personalUrl}`,
        );
    }

    public getUserBySlotLink(slotUrl: string) {
        return this.httpService.getRequest<IExternalUser>(`${this.routePrefix}/organizer/${slotUrl}`);
    }
}
