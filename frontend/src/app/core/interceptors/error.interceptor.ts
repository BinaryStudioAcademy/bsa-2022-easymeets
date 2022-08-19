/* eslint-disable no-param-reassign */
import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import firebase from 'firebase/compat';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import User = firebase.User;

@Injectable({
    providedIn: 'root',
})
export class ErrorInterceptor implements HttpInterceptor {
    handleError(error: HttpErrorResponse) {
        return throwError(() => new Error(error.message ?? 'Something went wrong'));
    }

    intercept(req: HttpRequest<unknown>, next: HttpHandler) {
        return next.handle(req).pipe(catchError(response => {
            if (response.status === 401) {
                if (response.headers.has('Token-Expired')) {
                    const currentUser = localStorage.getItem('user');
                    const userData = JSON.parse(currentUser!) as User;
                    const newToken = userData.getIdToken();

                    req = req.clone({
                        setHeaders: {
                            Authorization: `Bearer ${newToken}`,
                        },
                    });

                    return next.handle(req);
                }
            }

            return this.handleError(response);
        }));
    }
}
