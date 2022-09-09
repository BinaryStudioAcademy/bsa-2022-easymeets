import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IGoogleMeetCredentials } from '@core/models/IGoogleMeetCredentials';
import { GoogleMeetService } from '@core/services/google-meet.service';
import { SpinnerService } from '@core/services/spinner.service';
import { ZoomService } from '@core/services/zoom.service';

@Component({
    selector: 'app-video-conferencing',
    templateUrl: './video-conferencing.component.html',
    styleUrls: ['./video-conferencing.component.sass'],
})
export class VideoConferencingComponent extends BaseComponent implements OnInit {
    private redirectUri: string = document.location.href.split('?')[0];

    email: string | undefined;

    isLoad: boolean = false;

    availableAccounts: IGoogleMeetCredentials[] = [];

    selectedAccount?: IGoogleMeetCredentials;

    constructor(
        private spinnerService: SpinnerService,
        private zoomService: ZoomService,
        private router: Router,
        private activatedRoute: ActivatedRoute,
        private googleMeetService: GoogleMeetService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.checkActivatedRoute();
        this.getMeetData();
    }

    getMeetData() {
        this.googleMeetService.getAvailableCredentials()
            .pipe(this.untilThis)
            .subscribe(resp => {
                this.availableAccounts = resp;
            });
        this.googleMeetService.getCredentials()
            .pipe(this.untilThis)
            .subscribe(resp => {
                this.selectedAccount = resp;
            });
    }

    connectZoom() {
        this.zoomService.getZoomClientId()
            .pipe(this.untilThis)
            .subscribe(clientId => {
                this.zoomService.authorizeUser(this.redirectUri, clientId);
            });
    }

    logoutZoom() {
        this.zoomService.logoutZoom()
            .pipe(this.untilThis)
            .subscribe(() => {
                this.email = undefined;
            });
    }

    changeMeetAccount() {
        this.googleMeetService.createCredentials(this.selectedAccount!)
            .pipe(this.untilThis)
            .subscribe();
    }

    private checkActivatedRoute() {
        this.activatedRoute.queryParams.pipe(this.untilThis)
            .subscribe(params => {
                if (params['code']) {
                    const authCode = params['code'];

                    this.createZoomCredentials(authCode);
                } else {
                    this.getZoomClientEmail();
                }
            });
    }

    private createZoomCredentials(authCode: string) {
        this.spinnerService.show();
        this.zoomService.createZoomCredentials(authCode, this.redirectUri)
            .pipe(this.untilThis)
            .subscribe(result => {
                this.router.navigate([], {
                    queryParams: {
                        code: null,
                    },
                });
                this.isLoad = true;
                this.email = result.email;
                this.spinnerService.hide();
            });
    }

    private getZoomClientEmail() {
        this.spinnerService.show();
        this.zoomService.getZoomClientEmail()
            .pipe(this.untilThis)
            .subscribe(resp => {
                this.isLoad = true;
                this.email = resp.email;
                this.spinnerService.hide();
            });
    }
}
