import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { CheckOption } from '@core/interfaces/check-option';
import { UserCalendar } from '@core/interfaces/user-calendar';

@Component({
    selector: 'app-calendars-page',
    templateUrl: './calendars-page.component.html',
    styleUrls: ['./calendars-page.component.sass'],
})
export class CalendarsPageComponent implements OnInit {
    userCalendars: UserCalendar[];

    checkOptions: CheckOption[];

    ngOnInit(): void {
        const teams = [
            { id: 1, name: 'Binary Team', isSelected: false },
            { id: 2, name: 'Work 2', isSelected: false },
            { id: 3, name: 'Work Team 3', isSelected: false },
        ];

        this.userCalendars = [
            {
                id: 1,
                email: 'email@email.com',
                teamsFor: teams,
                teamFrom: teams,
                checkForConflicts: false,
            },
            {
                id: 2,
                email: 'email@email.com',
                teamsFor: teams,
                teamFrom: teams,
                checkForConflicts: false,
            },
            {
                id: 3,
                email: 'email@email.com',
                teamsFor: teams,
                teamFrom: teams,
                checkForConflicts: false,
            },
            {
                id: 4,
                email: 'email@email.com',
                teamsFor: teams,
                teamFrom: teams,
                checkForConflicts: false,
            },
            {
                id: 5,
                email: 'email@email.com',
                teamsFor: teams,
                teamFrom: teams,
                checkForConflicts: false,
            },
            {
                id: 6,
                email: 'email@email.com',
                teamsFor: teams,
                teamFrom: teams,
                checkForConflicts: false,
            },
        ];

        this.checkOptions = [
            { name: 'Yes', isSelected: false },
            { name: 'No', isSelected: true },
        ];
    }

    teamsFor = new FormControl('');

    teamsFrom = new FormControl('');

    displayedColumns: string[] = ['connected-calendars', 'events-for', 'events-from', 'check'];
}
