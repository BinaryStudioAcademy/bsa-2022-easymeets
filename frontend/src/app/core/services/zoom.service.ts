import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '@env/environment';

@Injectable({
    providedIn: 'root',
})
export class ZoomService {
    public authorizeUser(redirectUri: string) {
        const params = new HttpParams({
            fromObject: {
                response_type: 'code',
                client_id: environment.zoom.clientId,
                redirect_uri: redirectUri,
            },
        });

        document.location.href = `https://zoom.us/oauth/authorize?${params.toString()}`;
    }
}
