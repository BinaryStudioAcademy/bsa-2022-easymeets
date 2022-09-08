import { Injectable } from '@angular/core';
import { TeamStateChangeActionEnum } from '@core/enums/team-state-change-action.enum';
import { IImagePath } from '@core/models/IImagePath';
import { INewTeam } from '@core/models/INewTeam';
import { ITeam } from '@core/models/ITeam';
import { ITeamMember } from '@core/models/ITeamMember';
import { IUpdateTeam } from '@core/models/IUpdateTeam';
import { HttpInternalService } from '@core/services/http-internal.service';
import { BehaviorSubject, Observable, Subject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class TeamService {
    public routePrefix = '/team';

    public selectedTeamStorageKey = 'selected-team-id';

    private emitTeamStateChangeSource = new Subject<{ teamId: number; action: TeamStateChangeActionEnum }>();

    public teamStateChangeEmitted$ = this.emitTeamStateChangeSource.asObservable();

    private currentTeamSource = new BehaviorSubject<number | undefined>(this.getSelectedTeamId());

    public currentTeamEmitted$ = this.currentTeamSource.asObservable();

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public emitTeamStateChange(teamId: number, teamStateChangeActionEnum: TeamStateChangeActionEnum) {
        this.emitTeamStateChangeSource.next({ teamId, action: teamStateChangeActionEnum });
    }

    public emitCurrentTeamChange(currentTeamId?: number) {
        this.currentTeamSource.next(currentTeamId);

        if (currentTeamId) {
            localStorage.setItem(this.selectedTeamStorageKey, JSON.stringify(currentTeamId));
        }
    }

    public getSelectedTeamId(): number | undefined {
        const selectedTeamId = localStorage.getItem(this.selectedTeamStorageKey);

        if (!selectedTeamId) {
            return undefined;
        }

        return JSON.parse(selectedTeamId) as number;
    }

    public getCurrentUserTeams(): Observable<ITeam[]> {
        return this.httpService.getRequest<ITeam[]>(`${this.routePrefix}/user-teams`);
    }

    public getCurrentUserAdminAndOwnerTeams(): Observable<ITeam[]> {
        return this.httpService.getRequest<ITeam[]>(`${this.routePrefix}/user-teams-admin-owner`);
    }

    public getTeamMembers(teamId?: number) {
        return this.httpService.getRequest<ITeamMember[]>(`${this.routePrefix}/team-members/${teamId}`);
    }

    public validatePageLink(pageLink: string, teamId?: number) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/validatepagelink`, {
            pagelink: pageLink,
            id: teamId ?? '',
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

    public deleteTeamMember(teamMemberId: number) {
        return this.httpService.deleteRequest<ITeam>(`${this.routePrefix}/deleteMember/${teamMemberId}`);
    }

    public editTeam(team: IUpdateTeam) {
        return this.httpService.putRequest<ITeam>(`${this.routePrefix}`, team);
    }

    public createTeamMember(member: ITeamMember, teamId?: number) {
        return this.httpService.postRequest<ITeamMember>(`${this.routePrefix}/members/${teamId}`, member);
    }

    public updateTeamMember(member: ITeamMember) {
        return this.httpService.putRequest<ITeamMember>(`${this.routePrefix}/members`, member);
    }

    public uploadLogo(data: FormData, id?: number) {
        return this.httpService.putRequest<IImagePath>(`${this.routePrefix}/uploadlogo/${id ?? ''}`, data);
    }
}
