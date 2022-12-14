import { Injectable } from '@angular/core';
import { IImagePath } from '@core/models/IImagePath';
import { INewUser } from '@core/models/INewUser';
import { IUpdateUser } from '@core/models/IUpdateUser';
import { ILocalUser, IUser } from '@core/models/IUser';
import { failedGettingUserMessage } from '@shared/constants/shared-messages';
import { LocationType } from '@shared/enums/locationType';
import { BehaviorSubject, Observable, tap } from 'rxjs';

import { HttpInternalService } from './http-internal.service';
import { NotificationService } from './notification.service';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    public routePrefix = '/user';

    private onUserChanged = new BehaviorSubject<ILocalUser | undefined>(this.getLocalUser());

    public userChangedEvent$ = this.onUserChanged.asObservable();

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService, private notificationService: NotificationService) {}

    /* Api calls */
    public getCurrentUser(): Observable<IUser> {
        return this.httpService.getRequest<IUser>(`${this.routePrefix}/current`).pipe(
            tap({
                next: (user) => this.updateUser(user),
                error: () => this.notificationService.showErrorMessage(failedGettingUserMessage),
            }),
        );
    }

    public getUserByPersonalLink(link: string): Observable<IUser> {
        return this.httpService.getRequest<IUser>(`${this.routePrefix}/byLink/${link}`).pipe(
            tap({
                next: (user) => this.updateUser(user),
                error: () => this.notificationService.showErrorMessage(failedGettingUserMessage),
            }),
        );
    }

    public getUsersByEmailOrName(searchData: string): Observable<IUser[]> {
        return this.httpService.getRequest<IUser[]>(`${this.routePrefix}/search/${searchData}`);
    }

    public createUser(newUser: INewUser): Observable<IUser> {
        return this.httpService.postRequest<IUser>(`${this.routePrefix}`, newUser).pipe(
            tap({
                next: (user) => this.updateUser(user),
                error: () => this.notificationService.showErrorMessage('Something went wrong. Failed to create user.'),
            }),
        );
    }

    public editUser(put: IUpdateUser): Observable<IUser> {
        return this.httpService.putRequest<IUser>(`${this.routePrefix}`, put).pipe(
            tap({
                next: (user) => this.updateUser(user),
                error: () => this.notificationService.showErrorMessage('Something went wrong. Failed to update user.'),
            }),
        );
    }

    public checkExistingEmail(email: string): Observable<boolean> {
        const emailEncoded = encodeURIComponent(email);

        return this.httpService.getRequest<boolean>(`${this.routePrefix}/check-email?email=${emailEncoded}`).pipe(
            tap({
                error: () =>
                    this.notificationService.showErrorMessage('Something went wrong. Failed to verify email exists.'),
            }),
        );
    }

    public getUserMeetIntegrations(): Observable<LocationType[]> {
        return this.httpService.getRequest<LocationType[]>(`${this.routePrefix}/meet-integrations`);
    }

    public uploadImage(user: IUser | undefined, data: FormData): Observable<IImagePath> {
        return this.httpService.putRequest<IImagePath>(`${this.routePrefix}/uploadimage`, data).pipe(
            tap({
                next: (image) => {
                    if (user) {
                        user.image = image.path;
                        this.updateUser(user);
                    }
                },
                error: () => this.notificationService.showErrorMessage('Something went wrong. Failed to upload image.'),
            }),
        );
    }

    /* Local storage */
    public removeUser(): void {
        this.removeUserFromLocalStorage();
        this.onUserChanged.next(undefined);
    }

    private getLocalUser() {
        const user = localStorage.getItem('user');

        if (!user) {
            return undefined;
        }

        return JSON.parse(user) as ILocalUser;
    }

    private updateUser(user: IUser): void {
        if (user) {
            const localUser: ILocalUser = {
                id: user.id,
                uid: user.uid,
                userName: user.userName,
                image: user.image,
                timeFormat: user.timeFormat,
            };

            this.updateUserInLocalStorage(localUser);
            this.onUserChanged.next(localUser);
        }
    }

    private updateUserInLocalStorage(localUser: ILocalUser): void {
        localStorage.setItem('user', JSON.stringify(localUser));
    }

    private removeUserFromLocalStorage(): void {
        localStorage.removeItem('user');
    }
}
