import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
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
    public isNewTeam: boolean = true;

    public teamForm: FormGroup;

    public team: ITeam;

    public newTeam: INewTeam;

    public formGroup: FormGroup;

    public timeZoneValues = Object.values(TimeZone);

    constructor(private teamService: TeamService, public notificationService: NotificationService) {
        super();
    }

    ngOnInit(): void {
        this.formGroup = new FormGroup({
            name: new FormControl(),
            logo: new FormControl(),
            pageLink: new FormControl(),
            timeZone: new FormControl(),
            description: new FormControl(),
        });

        this.teamService.getTeamById(1)
            .pipe(this.untilThis)
            .subscribe((team) => {
                this.team = team;
                this.formGroup.patchValue({
                    name: team.name,
                    logo: team.image,
                    pageLink: team.pageLink,
                    timeZone: team.timeZone,
                    description: team.Description,

                });
                this.isNewTeam = false;
            });
    }
}
