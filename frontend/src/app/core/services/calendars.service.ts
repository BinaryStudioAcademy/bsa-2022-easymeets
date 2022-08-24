import { Injectable } from '@angular/core';
import { IUserCalendar } from '@core/models/calendar/IUserCalendar';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class CalendarsService {
    public routePrefix = '/calendar';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public createGoogleCalendarConnection(): Observable<boolean> {
        return this.httpService.postRequest<boolean>(`${this.routePrefix}/create-connection`, {});
    }

    public getUserGoogleCalendars(): Observable<IUserCalendar[]> {
        return this.httpService.getRequest<IUserCalendar[]>(`${this.routePrefix}/user-calendars`);
    }

    public deleteGoogleCalendar(id: bigint): Observable<boolean> {
        return this.httpService.deleteRequest<boolean>(`${this.routePrefix}/${id}`);
    }

    public updateGoogleCalendar(userCalendars: IUserCalendar[]): Observable<boolean> {
        return this.httpService.putRequest<boolean>(`${this.routePrefix}/update-calendar`, userCalendars);
    }
}
