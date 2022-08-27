import { Injectable } from '@angular/core';
import { IImagePath } from '@core/models/IImagePath';
import { INewUser } from '@core/models/INewUser';
import { IUpdateUser } from '@core/models/IUpdateUser';
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

    public editUser(put: IUpdateUser) {
        return this.httpService.putRequest<IUser>(`${this.routePrefix}`, put);
    }

    public checkExistingEmail(email: string) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/check-email?email=${email}`);
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
                image: _user.image,
            };

            localStorage.setItem('user', JSON.stringify(localUser));
        }
    }

    public removeUser() {
        localStorage.removeItem('user');
    }

    public updateUser(user: IUser) {
        localStorage.removeItem('user');
        this.setUser(user);
    }

    public uploadImage(data: FormData) {
        return this.httpService.putRequest<IImagePath>(`${this.routePrefix}/uploadimage`, data);
    }

    public getUserFromStorage(): ILocalUser {
        const user = localStorage.getItem('user');
        const localUser = JSON.parse(user!) as ILocalUser;

        return localUser;
    }

    public createZoomCredentials(authCode: string, redirectUri: string) {
        return this.httpService.postRequest(`${this.routePrefix}/zoom/add`, {
            code: authCode,
            grantType: 'authorization_code',
            redirectUri,
        });
    }

    public getZoomClientId() {
        return this.httpService.getStringRequest(`${this.routePrefix}/zoom/client`);
    }
}
