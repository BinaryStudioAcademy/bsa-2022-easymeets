import { Injectable } from '@angular/core';
import { IExternalAttendeeMeeting } from '@core/models/IExternalAttendeeMeeting';

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
}
