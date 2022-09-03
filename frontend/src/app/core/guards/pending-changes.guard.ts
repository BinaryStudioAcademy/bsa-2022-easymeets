import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { Observable } from 'rxjs';

export interface ComponentCanDeactivate {
    canDeactivate: () => boolean | Observable<boolean>;
}

@Injectable()
export class PendingChangesGuard implements CanDeactivate<ComponentCanDeactivate> {
    constructor(private confirmWindowService: ConfirmationWindowService) {}

    canDeactivate(component: ComponentCanDeactivate): boolean | Observable<boolean> {
        return component.canDeactivate() ? true : this.confirmWindowService.confirmLeaveDialog();
    }
}
