import { Injectable } from '@angular/core';
import { IGoogleMeetCredentials } from '@core/models/IGoogleMeetCredentials';
import { HttpInternalService } from '@core/services/http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class GoogleMeetService {
    private routePrefix = '/googlemeet';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getAvailableCredentials() {
        return this.httpService.getRequest<IGoogleMeetCredentials[]>(`${this.routePrefix}/credentials/available`);
    }

    public createCredentials(credentials: IGoogleMeetCredentials) {
        return this.httpService.postRequest<IGoogleMeetCredentials>(`${this.routePrefix}/credentials/create`, credentials);
    }
}
