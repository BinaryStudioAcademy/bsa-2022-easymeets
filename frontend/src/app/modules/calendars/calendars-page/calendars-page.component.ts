import { Component, OnInit } from '@angular/core';
import { getDefaultOptions } from '@core/helpers/options-helper';
import { getDefaultTeams } from '@core/helpers/teams-helper';
import { getDefaultCalendars } from '@core/helpers/users-calendar-helper';
import { ICheckOption } from '@core/interfaces/check-option';
import { ITeam } from '@core/interfaces/team-interface';
import { IUserCalendar } from '@core/interfaces/user-calendar';

@Component({
    selector: 'app-calendars-page',
    templateUrl: './calendars-page.component.html',
    styleUrls: ['./calendars-page.component.sass'],
})
export class CalendarsPageComponent implements OnInit {
    userCalendars: IUserCalendar[];

    allTeams: ITeam[];

    checkOptions: ICheckOption[];

    ngOnInit(): void {
        this.allTeams = getDefaultTeams();

        this.userCalendars = getDefaultCalendars();

        this.checkOptions = getDefaultOptions();
    }

    displayedColumns: string[] = ['connected-calendars', 'events-for', 'events-from', 'check'];
}
