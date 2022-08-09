/* eslint-disable no-param-reassign */
import { HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { from, lastValueFrom } from 'rxjs';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    // eslint-disable-next-line no-empty-function
    constructor(private authService: AuthService) {}

    public intercept(req: HttpRequest<any>, next: HttpHandler) {
        return from(this.handleAccess(req, next));
    }

    private async handleAccess(req: HttpRequest<any>, next: HttpHandler) {
        const accessToken = await this.authService.getCurrentToken();

        if (accessToken) {
            req = req.clone({ setHeaders: { Authorization: `Bearer ${accessToken}` } });
        }

        return lastValueFrom(next.handle(req));
    }
}
