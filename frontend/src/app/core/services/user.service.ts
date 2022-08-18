import { Injectable } from '@angular/core';
import { IUser } from '@core/models/IUser';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    public routePrefix = '/user';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getCurrentUser() {
        return this.httpService.getRequest<IUser>(`${this.routePrefix}/current`);
    }

    public editUser(put: IUser) {
        return this.httpService.putRequest<IUser>(`${this.routePrefix}`, put);
    }
}
