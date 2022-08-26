import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { UserService } from '@core/services/user.service';
import { ZoomService } from '@core/services/zoom.service';

@Component({
    selector: 'app-video-conferencing',
    templateUrl: './video-conferencing.component.html',
    styleUrls: ['./video-conferencing.component.sass'],
})
export class VideoConferencingComponent extends BaseComponent {
    private redirectUri: string = document.location.href.split('?')[0];

    constructor(
        private zoomService: ZoomService,
        private router: Router,
        private activatedRoute: ActivatedRoute,
        private userService: UserService,
    ) {
        super();
        activatedRoute.queryParams.subscribe(params => {
            if (params['code']) {
                const authCode = params['code'];

                this.userService.createZoomCredentials(authCode, this.redirectUri)
                    .pipe(this.untilThis)
                    .subscribe(() => router.navigate([], {
                        queryParams: {
                            code: null,
                        },
                    }));
            }
        });
    }

    public connectZoom() {
        this.zoomService.authorizeUser(this.redirectUri);
    }
}
