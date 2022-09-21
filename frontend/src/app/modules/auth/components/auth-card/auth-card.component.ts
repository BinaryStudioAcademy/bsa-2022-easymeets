import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TeamMemberService } from '@core/services/team-member.service';

@Component({
    selector: 'app-auth-card',
    templateUrl: './auth-card.component.html',
    styleUrls: ['./auth-card.component.sass'],
})
export class AuthCardComponent {
    teamId: number = 0;

    constructor(private route: ActivatedRoute, private teamService: TeamMemberService) {
        this.route.queryParams.subscribe(params => {
            this.teamId = params['teamId'];
        });
        this.teamService.addNode(this.teamId);
    }

    public navLinks = [
        { path: 'signin', label: 'Sign In' },
        { path: 'signup', label: 'Registration' },
        { path: 'forgot', label: 'Forgot' },
    ];

    public activeTab = this.navLinks[0].label;
}
