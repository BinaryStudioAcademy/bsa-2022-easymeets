import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root',
})
export class ZoomService {
    private authUri: string = 'https://zoom.us/oauth/authorize';

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
}
