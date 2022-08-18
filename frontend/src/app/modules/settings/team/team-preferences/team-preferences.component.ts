import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { INewTeam } from '@core/models/INewTeam';
import { ITeam } from '@core/models/ITeam';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { TimeZone } from '@shared/enums/timeZone';

@Component({
    selector: 'app-team-preferences',
    templateUrl: './team-preferences.component.html',
    styleUrls: ['./team-preferences.component.sass'],
})
export class TeamPreferencesComponent extends BaseComponent implements OnInit {
    constructor(private teamService: TeamService, public notificationService: NotificationService) {
        super();
    }

    public isNewTeam: boolean = true;

    public team: ITeam;

    public formGroup: FormGroup;

    public timeZoneValues = Object.values(TimeZone);

    public nameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(/^[іІїЇa-zA-Z\dа-яА-Я- ]*$/),
    ]);

    public descriptionControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(/^[.,іІїЇa-zA-Z\dа-яА-Я-\s]*$/),
    ]);

    public ngOnInit(): void {
        this.formGroup = new FormGroup({
            name: this.nameControl,
            logo: new FormControl(),
            pageLink: new FormControl(),
            timeZone: new FormControl(),
            description: this.descriptionControl,
        });
    }

    private getTeam(teamId: number) {
        this.teamService.getTeamById(teamId)
            .pipe(this.untilThis)
            .subscribe((team) => {
                this.team = team;
                this.formGroup.patchValue({
                    name: team.name,
                    image: team.image,
                    pageLink: team.pageLink,
                    timeZone: team.timeZone,
                    description: team.description,
                });
                this.isNewTeam = false;
            });
    }

    public deleteTeam() {
        this.teamService
            .deleteTeam(this.team.id)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.team = {} as ITeam;
                    this.isNewTeam = true;
                    this.notificationService.showSuccessMessage('Team information was deleted successfully.');
                },
                () => {
                    this.notificationService.showErrorMessage('There was an error while deleting.');
                },
            );
    }

    private createTeam(form: FormGroup) {
        const newTeam: INewTeam = {
            image: 'this.team.image',
            name: form.value.name,
            pageLink: form.value.pageLink,
            timeZone: form.value.timeZone,
            description: form.value.description,
        };

        this.teamService
            .createTeam(newTeam)
            .pipe(this.untilThis)
            .subscribe(
                (team) => {
                    this.team = team;
                    this.formGroup.patchValue({
                        name: team.name,
                        image: team.image,
                        pageLink: team.pageLink,
                        timeZone: team.timeZone,
                        description: team.description,
                    });
                    this.isNewTeam = false;
                    this.notificationService.showSuccessMessage('Team information was created successfully.');
                },
                () => {
                    this.notificationService.showErrorMessage('There was an error while creating.');
                },
            );
    }

    private editeTeam(form: FormGroup) {
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
                    this.isNewTeam = false;
                    this.notificationService.showSuccessMessage('Team information was updated successfully.');
                },
                () => {
                    this.notificationService.showErrorMessage('There was an error while updating.');
                },
            );
    }

    public OnSubmit(form: FormGroup) {
        if (this.isNewTeam) {
            this.createTeam(form);
        } else {
            this.editeTeam(form);
        }
    }
}
