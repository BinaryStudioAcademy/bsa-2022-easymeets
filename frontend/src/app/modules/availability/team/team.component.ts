import { Component, Input } from '@angular/core';
import { ITeamSlots } from '@core/interfaces/slot/team-slots-interface';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent {
    @Input()
    public teamSlots: ITeamSlots;

    constructor() {}
}
