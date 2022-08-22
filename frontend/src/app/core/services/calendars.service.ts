import { Injectable } from '@angular/core';
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
}
