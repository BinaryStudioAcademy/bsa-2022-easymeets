import { Component, OnInit } from '@angular/core';
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
        const teams = [
            { id: 1, name: 'Binary Team' },
            { id: 2, name: 'Work 2' },
            { id: 3, name: 'Work Team 3' },
        ];

        this.allTeams = teams;

        this.userCalendars = [
            {
                id: 1,
                email: 'email@email.com',
                teamsFor: null,
                teamFrom: null,
                checkForConflicts: false,
            },
            {
                id: 2,
                email: 'email@email.com',
                teamsFor: null,
                teamFrom: null,
                checkForConflicts: false,
            },
            {
                id: 3,
                email: 'email@email.com',
                teamsFor: null,
                teamFrom: null,
                checkForConflicts: false,
            },
            {
                id: 4,
                email: 'email@email.com',
                teamsFor: null,
                teamFrom: null,
                checkForConflicts: false,
            },
            {
                id: 5,
                email: 'email@email.com',
                teamsFor: null,
                teamFrom: null,
                checkForConflicts: false,
            },
            {
                id: 6,
                email: 'email@email.com',
                teamsFor: null,
                teamFrom: null,
                checkForConflicts: false,
            },
        ];

        this.checkOptions = [
            { name: 'Yes', value: true },
            { name: 'No', value: false },
        ];
    }

    displayedColumns: string[] = ['connected-calendars', 'events-for', 'events-from', 'check'];
}
