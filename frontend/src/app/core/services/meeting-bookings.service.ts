import { Injectable } from '@angular/core';
import { IMeetingBooking } from '@core/models/IMeetingBooking';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class MeetingBookingsService {
    public routePrefix = '/meeting/getThreeMeetingMembers';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getThreeMeetings(): Observable<IMeetingBooking[]> {
        return this.httpService.getRequest<IMeetingBooking[]>(`${this.routePrefix}`);
    }
}
