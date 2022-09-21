import { Injectable } from '@angular/core';
import { TeamStateChangeActionEnum } from '@core/enums/team-state-change-action.enum';
import { ICreateTeamMember } from '@core/models/ICreateTeamMember';
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

    constructor(
        private httpService: HttpInternalService,
    // eslint-disable-next-line no-empty-function
    ) { }

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
        return this.httpService.getRequest<ITeam[]>(`${this.routePrefix}/user-teams`);
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

    public deleteTeamMember(teamMemberId: bigint | undefined) {
        return this.httpService.deleteRequest<ITeam>(`${this.routePrefix}/deleteMember/${teamMemberId}`);
    }

    public editTeam(team: IUpdateTeam) {
        return this.httpService.putRequest<ITeam>(`${this.routePrefix}`, team);
    }

    public createTeamMember(member: ICreateTeamMember) {
        // eslint-disable-next-line no-debugger
        debugger;

        return this.httpService.postRequest<ICreateTeamMember>(`${this.routePrefix}/members`, member);
    }

    public updateTeamMember(member: ITeamMember) {
        return this.httpService.putRequest<ITeamMember>(`${this.routePrefix}/members`, member);
    }

    public uploadLogo(data: FormData, id?: number) {
        return this.httpService.putRequest<IImagePath>(`${this.routePrefix}/uploadlogo/${id ?? ''}`, data);
    }

    public sendInvitaionToMembers(teamMembersEmails: string[], teamId: number) {
        return this.httpService.postRequest(`${this.routePrefix}/invitation/${teamId}`, teamMembersEmails);
    }

    public deleteLogo(teamId: number) {
        return this.httpService.deleteRequest(`${this.routePrefix}/${teamId}/logo`);
    }
}
