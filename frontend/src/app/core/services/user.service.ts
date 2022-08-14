import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { User } from '@shared/models/user/user';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    public routePrefix = '/user';

    // eslint-disable-next-line no-empty-function
    constructor(private httpService: HttpInternalService) {}

    public getUser(id: number) {
        return this.httpService.getRequest<User>(`${this.routePrefix}/${id}`);
    }

    public editUsers(put: User) {
        return this.httpService.putRequest<User>(`${this.routePrefix}`, put);
    }
}
