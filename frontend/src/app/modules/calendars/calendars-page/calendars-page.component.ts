import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultOptions } from '@core/helpers/options-helper';
import { ICheckOption } from '@core/interfaces/check-option-interface';
import { IUserCalendar } from '@core/models/calendar/IUserCalendar';
import { ITeam } from '@core/models/ITeam';
import { CalendarsService } from '@core/services/calendars.service';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { GoogleOauthService } from '@core/services/google-oauth.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';

@Component({
    selector: 'app-calendars-page',
    templateUrl: './calendars-page.component.html',
    styleUrls: ['./calendars-page.component.sass'],
})
export class CalendarsPageComponent extends BaseComponent implements OnInit {
    userCalendars: IUserCalendar[];

    allTeams?: ITeam[];

    checkOptions: ICheckOption[];

    public connectGoogleCalendar = new EventEmitter<void>();

    public connectOutlookCalendar = new EventEmitter<void>();

    public connectAppleCalendar = new EventEmitter<void>();

    @Output() saveChangesClick: EventEmitter<void> = new EventEmitter();

    constructor(
        private teamService: TeamService,
        private oauthService: GoogleOauthService,
        private dialog: ConfirmationWindowService,
        private calendarService: CalendarsService,
        private notificationService: NotificationService,
        private router: Router,
    ) {
        super();
        this.connectGoogleCalendar.subscribe(() => {
            this.connectGoogle();
        });
    }

    ngOnInit(): void {
        this.refreshData();

        this.checkOptions = getDefaultOptions();
    }

    refreshData() {
        this.teamService
            .getCurrentUserTeams()
            .pipe(this.untilThis)
            .subscribe((response) => {
                this.allTeams = response;
            });

        /*this.calendarService
            .getUserGoogleCalendars()
            .pipe(this.untilThis)
            .subscribe((response) => {
                this.userCalendars = response;

                this.updateSelectedItems();
            });*/
        this.userCalendars = [
            { id: 1n, connectedCalendar: 'mycalendar1@gmail.com', checkForConflicts: true },
            { id: 2n, connectedCalendar: 'mycalendar2@gmail.com', checkForConflicts: false },
        ];
    }

    updateSelectedItems() {
        this.userCalendars = this.userCalendars.map((element) => {
            const teamsNames = element?.visibleForTeams?.map((x) => x.name);

            element.visibleForTeams = this.allTeams?.filter((x) => teamsNames?.includes(x.name));
            element.importEventsFromTeam = this.allTeams?.find((x) => x.name === element.importEventsFromTeam?.name);

            return element;
        });
    }

    connectGoogle() {
        this.oauthService.getRedirectUrl().subscribe(
            (response) => {
                window.location.href = response;
            },
            (error) => {
                this.notificationService.showErrorMessage(error);
            },
        );
    }

    removeCalendar(id: bigint) {
        this.calendarService
            .deleteGoogleCalendar(id)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notificationService.showSuccessMessage('Calendar was successfully deleted');
                    this.refreshData();
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    updateCalendar() {
        this.calendarService
            .updateGoogleCalendar(this.userCalendars)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notificationService.showSuccessMessage('Calendar was successfully updated');
                    this.refreshData();
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    confirmDialog() {
        this.dialog.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Google Calendar',
                    onClickEvent: this.connectGoogleCalendar,
                },
                {
                    class: 'confirm-accept-button',
                    label: 'Outlook',
                    onClickEvent: this.connectOutlookCalendar,
                },
                {
                    class: 'confirm-accept-button',
                    label: 'Apple Calendar',
                    onClickEvent: this.connectAppleCalendar,
                },
            ],
            title: 'Select Calendar',
            message:
                'Connect your calendar to let EasyMeets know when you are available and update your calendar as events are scheduled.',
        });
    }

    displayedColumns: string[] = ['connected-calendars', 'events-for', 'events-from', 'check', 'action'];
}
