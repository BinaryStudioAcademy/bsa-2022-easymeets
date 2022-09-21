import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { SpinnerService } from '@core/services/spinner.service';
import { Observable } from 'rxjs';

export interface ComponentCanDeactivate {
    canDeactivate: () => boolean | Observable<boolean>;
}

@Injectable()
export class PendingChangesGuard implements CanDeactivate<ComponentCanDeactivate> {
    // eslint-disable-next-line no-empty-function
    constructor(private confirmWindowService: ConfirmationWindowService, private spinner: SpinnerService) {}

    canDeactivate(component: ComponentCanDeactivate): boolean | Observable<boolean> {
        this.spinner.hide();

        return component.canDeactivate() ? true : this.confirmWindowService.confirmLeaveDialog();
    }
}
