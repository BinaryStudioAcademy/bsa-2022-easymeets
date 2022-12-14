/* eslint-disable no-param-reassign */
import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { switchMap, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
    providedIn: 'root',
})
export class ErrorInterceptor implements HttpInterceptor {
    // eslint-disable-next-line no-empty-function
    constructor(private authService: AuthService) { }

    handleError(error: HttpErrorResponse) {
        return throwError(() => new Error(error.message ?? 'Something went wrong'));
    }

    private handleExpired(req: HttpRequest<unknown>, next: HttpHandler) {
        const newToken = this.authService.getAccessToken();

        req = req.clone({
            setHeaders: {
                Authorization: `Bearer ${newToken}`,
            },
        });

        return next.handle(req);
    }

    intercept(req: HttpRequest<unknown>, next: HttpHandler) {
        return next.handle(req).pipe(catchError(response => {
            if (response.status === 401) {
                return this.authService.refreshToken()
                    .pipe(switchMap(() => this.handleExpired(req, next)));
            }

            return this.handleError(response);
        }));
    }
}
