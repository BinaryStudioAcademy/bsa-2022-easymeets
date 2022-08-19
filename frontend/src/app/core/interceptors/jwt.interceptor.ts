/* eslint-disable no-param-reassign */
import { HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    public intercept(req: HttpRequest<unknown>, next: HttpHandler) {
        return this.handleAccess(req, next);
    }

    private handleAccess(req: HttpRequest<unknown>, next: HttpHandler) {
        const accessToken = localStorage.getItem('access-token');

        if (accessToken) {
            req = req.clone({ setHeaders: { Authorization: `Bearer ${accessToken}` } });
        }

        return next.handle(req);
    }
}
