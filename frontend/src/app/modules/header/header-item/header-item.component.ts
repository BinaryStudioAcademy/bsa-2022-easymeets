import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeam } from '@core/models/ITeam';
import { ILocalUser } from '@core/models/IUser';
import { AuthService } from '@core/services/auth.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-header-item',
    templateUrl: './header-item.component.html',
    styleUrls: ['./header-item.component.sass'],
})
export class HeaderItemComponent extends BaseComponent implements OnInit {
    public teams: ITeam[] = [];
    
    public currentUser: ILocalUser;

    constructor(private authService: AuthService, private router: Router, private teamService: TeamService, private userService: UserService) {
        super();
    }

    ngOnInit(): void {
        this.currentUser = this.userService.getUserFromStorage();
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
