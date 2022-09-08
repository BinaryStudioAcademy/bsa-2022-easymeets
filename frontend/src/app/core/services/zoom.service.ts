import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IEmail } from '@core/models/IEmail';
import { HttpInternalService } from '@core/services/http-internal.service';
import { NotificationService } from '@core/services/notification.service';
import { Observable, tap } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class ZoomService {
    private authUri: string = 'https://zoom.us/oauth/authorize';

    private routePrefix = '/zoom';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService, private notificationService: NotificationService) {}

    public authorizeUser(redirectUri: string, clientId: string) {
        const params = new HttpParams({
            fromObject: {
                response_type: 'code',
                client_id: clientId,
                redirect_uri: redirectUri,
            },
        });

        document.location.href = `${this.authUri}?${params.toString()}`;
    }

    createZoomCredentials(authCode: string, redirectUri: string): Observable<IEmail> {
        return this.httpService
            .postRequest(`${this.routePrefix}/add`, {
                code: authCode,
                grantType: 'authorization_code',
                redirectUri,
            });
    }

    getZoomClientId(): Observable<string> {
        return this.httpService.getStringRequest(`${this.routePrefix}/client`).pipe(
            tap({
                error: () =>
                    this.notificationService.showErrorMessage('Something went wrong. Failed to fetch zoom client id.'),
            }),
        );
    }

    getZoomClientEmail(): Observable<IEmail> {
        return this.httpService.getRequest(`${this.routePrefix}/email`);
    }

    logoutZoom() {
        return this.httpService.deleteRequest(`${this.routePrefix}/token`).pipe(
            tap({
                error: () =>
                    this.notificationService.showErrorMessage('Something went wrong. Failed to logout zoom.'),
            }),
        );
    }
}
