import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class ZoomService {
    readonly authUri: string = 'https://zoom.us/oauth/authorize?response_type=code&client_id=DGyQTt7qQQuAH7EfiFHSA&redirect_uri=http%3A%2F%2Flocalhost%3A4200%2Fsettings%2Fintegrations%2Fvideo-conferencing';

    // eslint-disable-next-line no-empty-function
    constructor(private http: HttpInternalService) {}

    public authorizeUser() {
        document.location.href = this.authUri;
    }
}
