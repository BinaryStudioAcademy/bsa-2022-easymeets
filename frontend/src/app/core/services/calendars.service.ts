import { Injectable } from '@angular/core';
import { IUserCalendar } from '@core/models/calendar/IUserCalendar';
import { IUserCredentials } from '@core/models/IUserCredentials';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class CalendarsService {
    public routePrefix = '/calendar';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public createGoogleCalendarConnection(credentials: IUserCredentials): Observable<boolean> {
        return this.httpService.postRequest<boolean>(`${this.routePrefix}/create-connection`, credentials);
    }

    public getUserGoogleCalendars(): Observable<IUserCalendar[]> {
        return this.httpService.getRequest<IUserCalendar[]>(`${this.routePrefix}/user-calendars`);
    }
}
