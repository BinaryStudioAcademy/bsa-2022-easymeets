import { Component, EventEmitter, OnDestroy, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { TeamStateChangeActionEnum } from '@core/enums/team-state-change-action.enum';
import { ITeam } from '@core/models/ITeam';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TeamService } from '@core/services/team.service';
import { TeamPreferencesComponent } from '@modules/settings/team/team-preferences/team-preferences.component';
import { deletionMessage } from '@shared/constants/shared-messages';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-edit-team',
    templateUrl: './edit-team.component.html',
    styleUrls: ['./edit-team.component.sass'],
})
export class EditTeamComponent extends BaseComponent implements OnDestroy {
    private id: number | undefined;

    public team: ITeam;

    private deleteEventEmitter = new EventEmitter<void>();

    private deleteEventSubscription: Subscription;

    @ViewChild(TeamPreferencesComponent) teamPreferencesComponent: TeamPreferencesComponent;

    constructor(
        private activateRoute: ActivatedRoute,
        private teamService: TeamService,
        public notificationService: NotificationService,
        private router: Router,
        private spinnerService: SpinnerService,
        private confirmationWindowService: ConfirmationWindowService,
    ) {
        super();
        this.activateRoute.params.subscribe(params => {
            this.id = params['id'];
            this.spinnerService.show();
            this.loadTeamToEdit();
        });

        this.deleteEventSubscription = this.deleteEventEmitter.subscribe(() => this.deleteTeam());
    }

    private loadTeamToEdit() {
        if (this.id) {
            this.teamService.getTeamById(this.id)
                .pipe(this.untilThis)
                .subscribe({
                    next: (team) => {
                        this.team = team;
                        this.teamPreferencesComponent.formGroup.patchValue({
                            name: team.name,
                            image: team.image,
                            pageLink: team.pageLink,
                            timeZone: team.timeZone,
                            description: team.description,
                        });
                        this.teamPreferencesComponent.imageUrl = team.image;
                        this.spinnerService.hide();
                    },
                    error: (error) => {
                        this.notificationService.showErrorMessage(error);
                    },
                });
        }
    }

    public deleteButtonClick() {
        this.confirmationWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Yes',
                    onClickEvent: this.deleteEventEmitter,
                },
                {
                    class: 'confirm-cancel-button',
                    label: 'Cancel',
                    onClickEvent: new EventEmitter<void>(),
                },
            ],
            title: 'Confirm Team Deletion',
            message: deletionMessage,
        });
    }

    public deleteTeam() {
        this.teamService
            .deleteTeam(this.team.id)
            .pipe(this.untilThis)
            .subscribe({
                next: () => {
                    this.router.navigate(['/settings']);
                    this.teamService.emitTeamStateChange(this.team.id, TeamStateChangeActionEnum.Deleted);
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
            image: this.teamPreferencesComponent.imageUrl,
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

    override ngOnDestroy(): void {
        super.ngOnDestroy();
        this.deleteEventSubscription.unsubscribe();
    }
}
