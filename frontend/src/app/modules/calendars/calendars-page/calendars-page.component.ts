import { Component, EventEmitter, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultOptions } from '@core/helpers/options-helper';
import { ICheckOption } from '@core/interfaces/check-option-interface';
import { IUserCalendar } from '@core/models/calendar/IUserCalendar';
import { ITeam } from '@core/models/ITeam';
import { IUserCredentials } from '@core/models/IUserCredentials';
import { CalendarsService } from '@core/services/calendars.service';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { environment } from '@env/environment';

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

    constructor(
        private teamService: TeamService,
        private dialog: ConfirmationWindowService,
        private calendarService: CalendarsService,
        private notificationService: NotificationService,
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

        this.calendarService
            .getUserGoogleCalendars()
            .pipe(this.untilThis)
            .subscribe((response) => {
                this.userCalendars = response;

                this.userCalendars.forEach((element) => {
                    const teamsNames = element?.visibleForTeams?.map((x) => x.name);

                    element.visibleForTeams = this.allTeams?.filter((x) => teamsNames?.includes(x.name));
                    element.importEventsFromTeam = this.allTeams?.find(
                        (x) => x.name === element.importEventsFromTeam?.name,
                    );
                });
            });
    }

    removeCalendar(id: bigint) {
        this.calendarService
            .deleteGoogleCalendar(id)
            .pipe(this.untilThis)
            .subscribe((response) => {
                if (response) {
                    this.notificationService.showSuccessMessage('Calendar was successfully deleted');
                } else {
                    this.notificationService.showErrorMessage("Something went wrong. Calendar did't deleted");
                }
                this.refreshData();
            });
    }

    updateCalendar() {
        this.calendarService
            .updateGoogleCalendar(this.userCalendars)
            .pipe(this.untilThis)
            .subscribe((response) => {
                if (response) {
                    this.notificationService.showSuccessMessage('Calendars was successfully updated');
                } else {
                    this.notificationService.showErrorMessage("Something went wrong. Calendars did't update");
                }
                this.refreshData();
            });
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

    connectGoogle() {
        const credentials: IUserCredentials = {
            clientId: environment.googleCalendar.client_id,
            clientSecret: environment.googleCalendar.client_secret,
        };

        this.calendarService
            .createGoogleCalendarConnection(credentials)
            .pipe(this.untilThis)
            .subscribe((response) => {
                if (response) {
                    this.notificationService.showSuccessMessage('Calendar was successfully created');
                } else {
                    this.notificationService.showErrorMessage('Calendar is already exist');
                }
                this.refreshData();
            });
    }

    displayedColumns: string[] = ['connected-calendars', 'events-for', 'events-from', 'check'];
}
