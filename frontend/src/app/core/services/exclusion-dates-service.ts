import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class ExclusionDatesService {
    private isVisible$$ = new BehaviorSubject<boolean>(false);

    isVisible$ = this.isVisible$$.asObservable();

    show = () => this.isVisible$$.next(true);

    hide = () => this.isVisible$$.next(false);
}
