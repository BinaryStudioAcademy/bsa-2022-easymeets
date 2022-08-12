import { Injectable } from '@angular/core';
import { UploadImageDTO } from '@core/models/UploadImageDTO';
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

    public uploadImage(data: UploadImageDTO): Observable<HttpResponse> {
        return this.httpService.putRequest<HttpResponse>(`${this.routePrefix}`, data);
    }
}
