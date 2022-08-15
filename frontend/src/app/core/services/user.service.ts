import { Injectable } from '@angular/core';
import { IUser } from '@core/models/IUser';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    public routePrefix = '/user/current';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getCurrentUserById(currentUserId: number) {
        return this.httpService.getRequest<IUser>(`${this.routePrefix}/${currentUserId}`);
    }
}
