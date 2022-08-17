import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
// import { ITeam } from '@core/models/ITeam';
import { TimeZone } from '@shared/enums/timeZone';

@Component({
    selector: 'app-team-preferences',
    templateUrl: './team-preferences.component.html',
    styleUrls: ['./team-preferences.component.sass'],
})
export class TeamPreferencesComponent implements OnInit {
    // public team: ITeam;

    public userForm: FormGroup;

    public timeZoneValues = Object.values(TimeZone);

    constructor() { }

    ngOnInit(): void {
    }
}
