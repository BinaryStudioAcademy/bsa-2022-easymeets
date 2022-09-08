import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { SpinnerService } from '@core/services/spinner.service';
import { ZoomService } from '@core/services/zoom.service';

@Component({
    selector: 'app-video-conferencing',
    templateUrl: './video-conferencing.component.html',
    styleUrls: ['./video-conferencing.component.sass'],
})
export class VideoConferencingComponent extends BaseComponent {
    private redirectUri: string = document.location.href.split('?')[0];

    private clientId: string;

    email: string | undefined;

    isLoad: boolean = false;

    constructor(
        private spinnerService: SpinnerService,
        private zoomService: ZoomService,
        private router: Router,
        private activatedRoute: ActivatedRoute,
    ) {
        super();
        spinnerService.show();
        zoomService.getZoomClientId()
            .pipe(this.untilThis)
            .subscribe(clientId => {
                this.clientId = clientId;
            });
        activatedRoute.queryParams.subscribe(params => {
            if (params['code']) {
                const authCode = params['code'];

                this.zoomService.createZoomCredentials(authCode, this.redirectUri)
                    .pipe(this.untilThis)
                    .subscribe(result => {
                        router.navigate([], {
                            queryParams: {
                                code: null,
                            },
                        });
                        this.isLoad = true;
                        this.email = result.email;
                        spinnerService.hide();
                    });
            }
        });

        zoomService.getZoomClientEmail().subscribe(resp => {
            this.isLoad = true;
            this.email = resp.email;
            spinnerService.hide();
        });
    }

    connectZoom() {
        this.zoomService.authorizeUser(this.redirectUri, this.clientId);
    }

    logoutZoom() {
        this.zoomService.logoutZoom().subscribe(() => {
            this.email = undefined;
        });
    }
}
