import { Injectable } from '@angular/core';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class CalendarsService {
    public routePrefix = '/calendar';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}
}
