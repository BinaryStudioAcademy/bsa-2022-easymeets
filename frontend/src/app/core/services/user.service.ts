import { Injectable } from '@angular/core';
import { INewUser } from '@core/models/INewUser';
import { ILocalUser, IUser } from '@core/models/IUser';
import { map } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    public routePrefix = '/user';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getCurrentUser() {
        return this.httpService.getRequest<IUser>(`${this.routePrefix}/current`).pipe(
            map((resp) => {
                this.setUser(resp);

                return resp;
            }),
        );
    }

    public editUser(put: IUser) {
        return this.httpService.putRequest<IUser>(`${this.routePrefix}`, put);
    }

    public createUser(user: INewUser) {
        return this.httpService.postRequest<IUser>(`${this.routePrefix}`, user).pipe(
            map((resp) => {
                this.setUser(resp);

                return resp;
            }),
        );
    }

    public setUser(_user: IUser) {
        if (_user) {
            const localUser: ILocalUser = {
                id: _user.id,
                uid: _user.uid,
                userName: _user.userName,
            };

            localStorage.setItem('user', JSON.stringify(localUser));
        }
    }

    public removeUser() {
        localStorage.removeItem('user');
    }

    public getUserFromStorage(): ILocalUser {
        const user = localStorage.getItem('user');
        const localUser = JSON.parse(user!) as ILocalUser;

        return localUser;
    }
}
