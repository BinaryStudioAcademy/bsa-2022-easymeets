import { Injectable } from '@angular/core';
import { ITeam } from '@core/interfaces/team-interface';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

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
}
