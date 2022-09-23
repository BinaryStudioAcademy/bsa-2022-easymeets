import { Injectable } from '@angular/core';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { ITimeZone } from '@core/models/ITimeZone';
import { BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class TimeZoneService {
    private onTimeZoneChanged = new BehaviorSubject<ITimeZone>(getDefaultTimeZone());

    public timeZoneChangedEvent$ = this.onTimeZoneChanged.asObservable();

    timeZoneChanged(newTimeZone: ITimeZone) {
        this.onTimeZoneChanged.next(newTimeZone);
    }
}
