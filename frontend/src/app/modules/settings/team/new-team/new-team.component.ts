import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { TeamStateChangeActionEnum } from '@core/enums/team-state-change-action.enum';
import { INewTeam } from '@core/models/INewTeam';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { TeamPreferencesComponent } from '@modules/settings/team/team-preferences/team-preferences.component';

@Component({
    selector: 'app-new-team',
    templateUrl: './new-team.component.html',
    styleUrls: ['./new-team.component.sass'],
})
export class NewTeamComponent extends BaseComponent {
    constructor(
        private teamService: TeamService,
        public notificationService: NotificationService,
        private router: Router,
    ) {
        super();
    }

    @ViewChild(TeamPreferencesComponent) teamPreferencesComponent: TeamPreferencesComponent;

    public createTeam() {
        const form = this.teamPreferencesComponent.formGroup;
        const newTeam: INewTeam = {
            image: this.teamPreferencesComponent.imageUrl,
            name: form.value.name,
            pageLink: form.value.pageLink,
            timeZoneName: form.value.timeZone.name,
            timeZoneValue: form.value.timeZone.timeValue,
            description: form.value.description,
        };

        this.teamService
            .createTeam(newTeam)
            .pipe(this.untilThis)
            .subscribe(
                (team) => {
                    this.teamService.emitTeamStateChange(team.id, TeamStateChangeActionEnum.Created);
                    this.notificationService.showSuccessMessage('Team was created successfully.');
                    this.router.navigate(['settings', 'teams', 'edit', team.id.toString()]);
                },
                () => {
                    this.notificationService.showErrorMessage('There was an error while creating.');
                },
            );
    }
}
