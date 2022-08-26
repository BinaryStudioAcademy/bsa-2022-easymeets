import { Component, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeam } from '@core/models/ITeam';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TeamService } from '@core/services/team.service';
import { TeamPreferencesComponent } from '@modules/settings/team/team-preferences/team-preferences.component';

@Component({
    selector: 'app-edit-team',
    templateUrl: './edit-team.component.html',
    styleUrls: ['./edit-team.component.sass'],
})
export class EditTeamComponent extends BaseComponent {
    private id: number | undefined;

    public team: ITeam;

    @ViewChild(TeamPreferencesComponent) teamPreferencesComponent: TeamPreferencesComponent;

    constructor(
        private activateRoute: ActivatedRoute,
        private teamService: TeamService,
        public notificationService: NotificationService,
        private router: Router,
        private spinnerService: SpinnerService,
    ) {
        super();
        this.activateRoute.params.subscribe(params => {
            this.id = params['id'];
            this.spinnerService.show();
            this.teamService.getTeamById(this.id)
                .pipe(this.untilThis)
                .subscribe((team) => {
                    this.team = team;
                    this.teamPreferencesComponent.formGroup.patchValue({
                        name: team.name,
                        image: team.image,
                        pageLink: team.pageLink,
                        timeZone: team.timeZone,
                        description: team.description,
                    });
                    this.spinnerService.hide();
                });
        });
    }

    public deleteTeam() {
        this.teamService
            .deleteTeam(this.team.id)
            .pipe(this.untilThis)
            .subscribe({
                next: () => {
                    this.router.navigate(['../'], { relativeTo: this.activateRoute });
                    this.teamService.emitTeamDeletion(this.team.id);
                    this.notificationService.showSuccessMessage('Team information was deleted successfully.');
                },
                error: () => {
                    this.notificationService.showErrorMessage('There was an error while deleting.');
                },
            });
    }

    public editTeam() {
        const form = this.teamPreferencesComponent.formGroup;
        const editedTeam: ITeam = {
            id: this.team.id,
            image: this.team.image,
            name: form.value.name,
            pageLink: form.value.pageLink,
            timeZone: form.value.timeZone,
            description: form.value.description,
        };

        this.teamService
            .editTeam(editedTeam)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notificationService.showSuccessMessage('Team information was updated successfully.');
                },
                () => {
                    this.notificationService.showErrorMessage('There was an error while updating.');
                },
            );
    }
}
