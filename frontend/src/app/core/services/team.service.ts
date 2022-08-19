import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { INewTeam } from '@core/models/INewTeam';
import { ITeam } from '@core/models/ITeam';
import { HttpInternalService } from '@core/services/http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class TeamService {
    public routePrefix = '/team';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {
    }

    public validatePageLink(teamId: number, pagelink: string) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/validatepagelink`, new HttpParams()
            .set('id', teamId)
            .set('pagelink', pagelink));
    }

    public getNewPageLink(teamId: number, teamname: string) {
        return this.httpService.getStringRequest(`${this.routePrefix}/newpagelink`, new HttpParams()
            .set('id', teamId)
            .set('teamname', teamname));
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
