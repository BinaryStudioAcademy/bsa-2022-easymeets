import { EventEmitter, Injectable, OnDestroy } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router } from '@angular/router';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { Observable, Subscription } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class PasswordSlotGuard implements CanActivate, OnDestroy {
    private link: string | null;

    private leaveEventEmitter = new EventEmitter<void>();

    private leaveEventSubscription: Subscription;

    // eslint-disable-next-line no-empty-function
    constructor(private confirmationWindowService: ConfirmationWindowService, private router: Router) {
        this.leaveEventSubscription = this.leaveEventEmitter.subscribe(() => this.leaveSlotPasswordWindow());
    }

    canActivate(route: ActivatedRouteSnapshot): Observable<boolean> | Promise<boolean> | boolean {
        this.link = route.paramMap.get('slotLink');
        this.confirmationWindowService.openSlotPasswordDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Ok',
                    onClickEvent: new EventEmitter<void>(),
                },
                {
                    class: 'confirm-cancel-button',
                    label: 'Cancel',
                    onClickEvent: this.leaveEventEmitter,
                },
            ],
            title: 'Enter Slot Password',
        });

        return true;
    }

    ngOnDestroy(): void {
        this.leaveEventSubscription.unsubscribe();
    }

    private leaveSlotPasswordWindow() {
        this.router.navigateByUrl('');
    }
}
