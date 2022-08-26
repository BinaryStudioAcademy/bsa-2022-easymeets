import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeam } from '@core/models/ITeam';
import { AuthService } from '@core/services/auth.service';
import { TeamService } from '@core/services/team.service';

@Component({
    selector: 'app-header-item',
    templateUrl: './header-item.component.html',
    styleUrls: ['./header-item.component.sass'],
})
export class HeaderItemComponent extends BaseComponent implements OnInit {
    public teams: ITeam[] = [];

    constructor(private authService: AuthService, private router: Router, private teamService: TeamService) {
        super();
    }

    ngOnInit(): void {
        this.teamService.getCurrentUserTeams()
            .pipe(this.untilThis)
            .subscribe((teams) => {
                this.teams = teams;
            });
        this.teamService.teamCreationEmitted$.subscribe(team => this.teams.push(team));
        this.teamService.teamDeletionEmitted$.subscribe(teamId => {
            const index = this.teams.findIndex(team => team.id === teamId);

            if (index !== undefined) {
                this.teams.splice(index, 1);
            }
        });
    }

    public navLinks = [
        { path: '../availability', label: 'Availability' },
        { path: '../bookings', label: 'Bookings' },
    ];

    public activeTab = this.navLinks[0].label;

    public logout() {
        return this.authService.signOut().then(() => {
            this.router.navigateByUrl('auth');
        });
    }
}
