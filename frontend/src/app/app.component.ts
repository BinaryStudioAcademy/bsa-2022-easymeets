import { Component, OnInit } from '@angular/core';
import { NavigationCancel, NavigationEnd, NavigationError, NavigationStart, Router } from '@angular/router';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-root',
    template: '<app-loading-spinner></app-loading-spinner><router-outlet></router-outlet>',
})
export class AppComponent implements OnInit {
    constructor(
        private router: Router,
        private spinner: SpinnerService,
        private notificationService: NotificationService,
    ) {
        this.listenRouter();
    }

    public ngOnInit(): void {
        console.log('FFFFFFF');
        //this.notificationService.showUsualMessage('Successfully updated');
        this.notificationService.showErrorMessage('Image has invalid dimension');
    }

    private listenRouter() {
        this.router.events.subscribe((event) => {
            if (event instanceof NavigationStart) {
                this.spinner.show();
            }
            if (
                event instanceof NavigationEnd ||
                event instanceof NavigationCancel ||
                event instanceof NavigationError
            ) {
                this.spinner.hide();
            }
        });
    }
}
