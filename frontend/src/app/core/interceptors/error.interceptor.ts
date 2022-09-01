/* eslint-disable no-param-reassign */
import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { from, lastValueFrom, throwError } from 'rxjs';
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

    private async handleExpired(req: HttpRequest<unknown>, next: HttpHandler) {
        await this.authService.refreshToken();
        const newToken = this.authService.getAccessToken();

        req = req.clone({
            setHeaders: {
                Authorization: `Bearer ${newToken}`,
            },
        });

        return lastValueFrom(next.handle(req));
    }

    intercept(req: HttpRequest<unknown>, next: HttpHandler) {
        return next.handle(req).pipe(catchError(response => {
            if (response.status === 401) {
                return from(this.handleExpired(req, next));
            }

            return this.handleError(response);
        }));
    }
}
