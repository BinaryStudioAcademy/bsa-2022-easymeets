import { Injectable } from '@angular/core';
import { IMeeting } from '@core/models/IMeeting';
import { INewMeeting } from '@core/models/INewMeeting';
import { INewMeetingMember } from '@core/models/INewMeetingTeamMember';
import { IOrderedMeetingTimes } from '@core/models/IOrderedMeetingTimes';
import { IUpdateMeeting } from '@core/models/IUpdateMeeting';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class NewMeetingService {
    public routePrefix = '/meeting';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getTeamMembersByName(name: string, teamId?: number) {
        return this.httpService.getRequest<INewMeetingMember[]>(
            `${this.routePrefix}/getTeamMembersByName/${name}/${teamId ?? ''}`,
        );
    }

    public getTeamMembersById(userId?: bigint, teamId?: number) {
        return this.httpService.getRequest<INewMeetingMember>(
            `${this.routePrefix}/getTeamMembersById/${userId ?? ''}/${teamId ?? ''}`,
        );
    }

    public saveNewMeeting(data: INewMeeting) {
        return this.httpService.postRequest<INewMeeting>(`${this.routePrefix}`, data);
    }

    public getOrderedMeetingTimes(slotId: bigint) {
        return this.httpService.getRequest<IOrderedMeetingTimes[]>(`${this.routePrefix}/ordered-times/${slotId}`);
    }

    public getMeetingById(id: bigint) {
        return this.httpService.getRequest<IMeeting>(`${this.routePrefix}/${id}`);
    }

    public updateMeeting(data: IUpdateMeeting) {
        return this.httpService.putRequest<INewMeeting>(`${this.routePrefix}`, data);
    }
}
