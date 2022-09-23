import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthFormService } from '@core/services/auth-form.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { TeamMemberService } from '@core/services/team-member.service';
import { switchMap } from 'rxjs';

@Component({
    selector: 'app-auth-card',
    templateUrl: './auth-card.component.html',
    styleUrls: ['./auth-card.component.sass'],
})
export class AuthCardComponent extends BaseComponent {
    teamId: number = 0;

    constructor(
        private route: ActivatedRoute,
        private teamMemberService: TeamMemberService,
        private authService: AuthFormService,
        private teamService: TeamService,
        private notificationService: NotificationService,
    ) {
        super();
        this.authService
            .teamMemberAddedEmitted$
            .pipe(
                this.untilThis,
                switchMap(resp => this.teamService.createTeamMember(resp)),
            )
            .subscribe({ next: () => {
                this.notificationService.showInfoMessage('Current user was added to team');
            } });

        this.route.queryParams.subscribe(params => {
            this.teamId = params['teamId'];
        });
        this.teamMemberService.setTeamId(this.teamId);
    }

    public navLinks = [
        { path: 'signin', label: 'Sign In' },
        { path: 'signup', label: 'Registration' },
        { path: 'forgot', label: 'Forgot' },
    ];

    public activeTab = this.navLinks[0].label;
}
