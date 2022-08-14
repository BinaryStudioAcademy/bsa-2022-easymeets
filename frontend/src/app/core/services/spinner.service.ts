import { Injectable } from '@angular/core';
import { BehaviorSubject, delay } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class SpinnerService {
    private isLoading$$ = new BehaviorSubject<boolean>(false);

    isLoading$ = this.isLoading$$
        .asObservable()
        .pipe(delay(0));

    show = () => this.isLoading$$.next(true);

    hide = () => this.isLoading$$.next(false);
}
