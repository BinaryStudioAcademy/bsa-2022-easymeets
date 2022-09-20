import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { TeamStateChangeActionEnum } from '@core/enums/team-state-change-action.enum';
import { INewTeam } from '@core/models/INewTeam';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { TeamPreferencesComponent } from '@modules/settings/team/team-preferences/team-preferences.component';
import { of, switchMap } from 'rxjs';

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

    private createdId: number;

    public createTeam() {
        const form = this.teamPreferencesComponent.formGroup;
        const newTeam: INewTeam = {
            name: form.value.name,
            pageLink: form.value.pageLink,
            timeZone: form.value.timeZone,
            description: form.value.description,
        };

        this.teamService
            .createTeam(newTeam)
            .pipe(
                this.untilThis,
                switchMap((team) => {
                    this.createdId = team.id;
                    if (this.teamPreferencesComponent.image) {
                        return this.teamService.uploadLogo(this.teamPreferencesComponent.image, this.createdId);
                    }

                    return of(null);
                }),
            )
            .subscribe(
                () => {
                    this.teamService.emitTeamStateChange(this.createdId, TeamStateChangeActionEnum.Created);
                    this.notificationService.showSuccessMessage('Team was created successfully.');
                    this.router.navigate(['settings', 'teams', 'edit', this.createdId.toString()]);
                },
                () => {
                    this.notificationService.showErrorMessage('There was an error while creating.');
                },
            );
    }
}
