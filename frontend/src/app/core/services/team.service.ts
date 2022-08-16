import { Injectable } from '@angular/core';
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

    public getTeamById(teamId: number) {
        return this.httpService.getRequest<ITeam>(`${this.routePrefix}/${teamId}`);
    }

    public editTeam(put: ITeam) {
        return this.httpService.putRequest<ITeam>(`${this.routePrefix}`, put);
    }
}
