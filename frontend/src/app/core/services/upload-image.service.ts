import { Injectable } from '@angular/core';
import { HttpResponse } from '@microsoft/signalr';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class UploadImageService {
    public routePrefix = '/uploadimage';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public uploadImage(data: FormData, userId: number): Observable<HttpResponse> {
        return this.httpService.putRequest<HttpResponse>(`${this.routePrefix}/${userId}`, data);
    }
}
