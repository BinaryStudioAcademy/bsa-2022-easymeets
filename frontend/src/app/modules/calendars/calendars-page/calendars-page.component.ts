import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
    selector: 'app-calendars-page',
    templateUrl: './calendars-page.component.html',
    styleUrls: ['./calendars-page.component.sass'],
})
export class CalendarsPageComponent {
    teamsFor = new FormControl('');

    teamsFrom = new FormControl('');

    teamsList: string[] = ['Binary Team', 'Work 2', 'Work Team 3'];

    public displayedColumns: string[] = ['connected-calendars', 'events-for', 'events-from', 'check'];

    public data: string[] = ['one', 'two', 'three', 'four', 'five'];
}
