import { Component, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { Router } from '@angular/router';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent {
    @Input() public slot: IAvailabilitySlot;

    @Input() public hasOwner: boolean;

    public isChecked: boolean = true;

    private unsubscribe$ = new Subject<void>();

    // eslint-disable-next-line no-empty-function
    constructor(private http: AvailabilitySlotService, private notifications: NotificationService, private router: Router) {}

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    public deleteSlot() {
        this.http
            .deleteSlot(this.slot.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                () => {
                    this.notifications.showSuccessMessage('Slot was successfully deleted');
                },
                (error) => {
                    this.notifications.showErrorMessage(error);
                },
            );
    }
}
