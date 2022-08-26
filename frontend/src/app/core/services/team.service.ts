import { Injectable } from '@angular/core';
import { INewTeam } from '@core/models/INewTeam';
import { ITeam } from '@core/models/ITeam';
import { HttpInternalService } from '@core/services/http-internal.service';
import { Observable, Subject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class TeamService {
    public routePrefix = '/team';

    private emitTeamCreationSource = new Subject<ITeam>();

    public teamCreationEmitted$ = this.emitTeamCreationSource.asObservable();

    private emitTeamDeletionSource = new Subject<number>();

    public teamDeletionEmitted$ = this.emitTeamDeletionSource.asObservable();

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public emitTeamCreation(newTeam: ITeam) {
        this.emitTeamCreationSource.next(newTeam);
    }

    public emitTeamDeletion(deletedTeamId: number) {
        this.emitTeamDeletionSource.next(deletedTeamId);
    }

    public getCurrentUserTeams(): Observable<ITeam[]> {
        return this.httpService.getRequest<ITeam[]>(`${this.routePrefix}/user-teams`);
    }

    public getCurrentUserAdminTeams(): Observable<ITeam[]> {
        return this.httpService.getRequest<ITeam[]>(`${this.routePrefix}/user-teams-admin`);
    }

    public validatePageLink(teamId: number | undefined, pageLink: string) {
        return this.httpService.getRequest<boolean>(
            `${this.routePrefix}/validatepagelink`, (
                (teamId === undefined)
                    ? {
                        pagelink: pageLink,
                    }
                    : {
                        id: teamId,
                        pagelink: pageLink,
                    }),
        );
    }

    public getNewPageLink(teamId: number, teamName: string) {
        return this.httpService.getStringRequest(`${this.routePrefix}/newpagelink`, { id: teamId, teamname: teamName });
    }

    public getTeamById(teamId: number | undefined) {
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
