/* eslint-disable no-param-reassign */
import { HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    // eslint-disable-next-line no-empty-function
    constructor(private authService: AuthService) {}

    public intercept(req: HttpRequest<unknown>, next: HttpHandler) {
        return this.handleAccess(req, next);
    }

    private handleAccess(req: HttpRequest<unknown>, next: HttpHandler) {
        const accessToken = this.authService.getAccessToken();

        if (accessToken) {
            req = req.clone({ setHeaders: { Authorization: `Bearer ${accessToken}` } });
        }

        return next.handle(req);
    }
}
