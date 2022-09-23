import { Component, EventEmitter, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultOptions } from '@core/helpers/options-helper';
import { ICheckOption } from '@core/interfaces/check-option-interface';
import { IUserCalendar } from '@core/models/calendar/IUserCalendar';
import { ITeam } from '@core/models/ITeam';
import { CalendarsService } from '@core/services/calendars.service';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { GoogleOauthService } from '@core/services/google-oauth.service';
import { NotificationService } from '@core/services/notification.service';
import { SettingPageService } from '@core/services/setting-page.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TeamService } from '@core/services/team.service';
import { mergeMap, switchMap } from 'rxjs';

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
        private oauthService: GoogleOauthService,
        private dialog: ConfirmationWindowService,
        private calendarService: CalendarsService,
        private notificationService: NotificationService,
        private settingPageService: SettingPageService,
        private spinnerService: SpinnerService,
    ) {
        super();
        this.connectGoogleCalendar.subscribe(() => {
            this.connectGoogle();
        });
    }

    ngOnInit(): void {
        this.settingPageService.updateButtonClickEvent$
            .pipe(this.untilThis)
            .pipe(switchMap(() => this.updateCalendar()))
            .subscribe({
                next: () => {
                    this.notificationService.showSuccessMessage('Calendars were successfully updated');
                    this.loadData();
                },
                error: () =>
                    this.notificationService.showErrorMessage('Something went wrong. Calendars are not updated'),
            });

        this.loadData();

        this.checkOptions = getDefaultOptions();
    }

    loadData() {
        this.spinnerService.show();
        this.teamService
            .getCurrentUserTeams()
            .pipe(
                this.untilThis,
                mergeMap((value) => {
                    this.allTeams = value;

                    return this.calendarService.getUserGoogleCalendars();
                }),
            )
            .subscribe((response) => {
                this.userCalendars = response;
                this.updateSelectedItems();
                this.settingPageService.updateButtonActive(true);
                this.spinnerService.hide();
            });
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
            .subscribe({
                next: () => {
                    this.notificationService.showSuccessMessage('Calendar was successfully deleted');
                    this.loadData();
                },
                error: (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            });
    }

    updateCalendar() {
        return this.calendarService.updateGoogleCalendar(this.userCalendars);
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
