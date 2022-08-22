import { Injectable } from '@angular/core';
import { INewTeam } from '@core/models/INewTeam';
import { ITeam } from '@core/models/ITeam';
import { HttpInternalService } from '@core/services/http-internal.service';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class TeamService {
    public routePrefix = '/team';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getCurrentUserTeams(): Observable<ITeam[]> {
        return this.httpService.getRequest<ITeam[]>(`${this.routePrefix}/user-teams`);
    }

    public validatePageLink(teamId: number, pageLink: string) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/validatepagelink`, {
            id: teamId,
            pagelink: pageLink,
        });
    }

    public getNewPageLink(teamId: number, teamName: string) {
        return this.httpService.getStringRequest(`${this.routePrefix}/newpagelink`, { id: teamId, teamname: teamName });
    }

    public getTeamById(teamId: number) {
        return this.httpService.getRequest<ITeam>(`${this.routePrefix}/${teamId}`);
    }

    public createTeam(newTeam: INewTeam) {
        return this.httpService.postRequest<ITeam>(`${this.routePrefix}`, newTeam);
    }

    public deleteTeam(teamId: number) {
        return this.httpService.deleteRequest<ITeam>(`${this.routePrefix}/${teamId}`);
    }

    public editTeam(team: ITeam) {
        return this.httpService.putRequest<ITeam>(`${this.routePrefix}`, team);
    }
}
