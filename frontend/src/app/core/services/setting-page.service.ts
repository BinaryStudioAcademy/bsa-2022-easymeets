import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class SettingPageService {
    private onUpdateButtonActive = new Subject<boolean>();

    private onUpdateButtonClick = new Subject<void>();

    updateButtonActiveEvent$ = this.onUpdateButtonActive.asObservable();

    updateButtonClickEvent$ = this.onUpdateButtonClick.asObservable();

    updateButtonActive(isActive: boolean) {
        this.onUpdateButtonActive.next(isActive);
    }

    updateButtonClick() {
        this.onUpdateButtonClick.next();
    }
}
