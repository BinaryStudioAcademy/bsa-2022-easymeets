import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class GoogleOauthService {
    public routePrefix = '/googleoauth';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getRedirectUrl(): Observable<string> {
        return this.httpService.getStringRequest(`${this.routePrefix}/redirect`);
    }

    public redirectToCodeMethod(): Observable<null> {
        return this.httpService.getRequest<null>(`${this.routePrefix}/code`);
    }
}
