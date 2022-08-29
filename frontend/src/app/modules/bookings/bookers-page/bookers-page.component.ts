import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IUserMeeting } from '@core/models/IUserMeeting';
import { MeetingBookingsService } from '@core/services/meeting-bookings.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-bookers-page',
    templateUrl: './bookers-page.component.html',
    styleUrls: ['./bookers-page.component.sass'],
})
export class BookersPageComponent extends BaseComponent {
    private id: number;

    public members: IUserMeeting[];

    constructor(
        private router: Router,
        private activateRoute: ActivatedRoute,
        private spinnerService: SpinnerService,
        private meetingService: MeetingBookingsService,
        private notifications: NotificationService,
    ) {
        super();
        this.activateRoute.params.subscribe(params => {
            this.id = params['id'];
            this.spinnerService.show();
            this.loadMembers();
        });
    }

    private loadMembers() {
        this.meetingService.getAllMembers(this.id)
            .pipe(this.untilThis)
            .subscribe(
                members => {
                    this.members = members;
                    this.spinnerService.hide();
                },
                error => this.notifications.showErrorMessage(error),
            );
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
