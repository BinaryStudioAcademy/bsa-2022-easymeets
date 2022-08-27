import { Component, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISaveAvailability } from '@core/models/save-availability-slot/ISaveAvailability';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { NewAvailabilityComponent } from '@modules/availability/new-slot/new-availability/new-availability.component';

@Component({
    selector: 'app-edit-availability-page',
    templateUrl: './edit-availability-page.component.html',
    styleUrls: ['./edit-availability-page.component.sass'],
})
export class EditAvailabilityPageComponent extends BaseComponent {
    private id: bigint | undefined;

    public slot?: IAvailabilitySlot;

    @ViewChild(NewAvailabilityComponent) newAvailabilityComponent: NewAvailabilityComponent;

    constructor(
        private router: Router,
        private activateRoute: ActivatedRoute,
        private spinnerService: SpinnerService,
        private http: AvailabilitySlotService,
        private notifications: NotificationService,
    ) {
        super();
        this.activateRoute.params.subscribe((params) => {
            this.id = params['id'];
            this.spinnerService.show();
            this.http.getSlotById(this.id).subscribe((slotResponse) => {
                this.slot = slotResponse;
                this.spinnerService.hide();
            });
        });
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    sendChanges() {
        const general = this.newAvailabilityComponent.generalComponent.settings;

        general.isEnabled = this.newAvailabilityComponent.isActive;
        const advancedSettings = this.newAvailabilityComponent.generalComponent.addAdvanced
            ? this.newAvailabilityComponent.generalComponent.advancedSettings!
            : null;
        const updateAvailability: ISaveAvailability = {
            generalDetails: this.newAvailabilityComponent.generalComponent.settings,
            eventDetails: this.newAvailabilityComponent.eventDetailComponent.settings,
            hasAdvancedSettings: this.newAvailabilityComponent.generalComponent.addAdvanced,
            schedule: this.newAvailabilityComponent.scheduleComponent.schedule,
            emailSettings: this.newAvailabilityComponent.notificationEmailsComponent.settings,
            advancedSettings,
        };

        this.http
            .updateSlot(updateAvailability, this.slot?.id)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notifications.showSuccessMessage('Slot was successfully updated');
                    this.goToPage('/availability');
                },
                (error) => {
                    this.notifications.showErrorMessage(error);
                },
            );
    }

    public deleteSlot() {
        this.http
            .deleteSlot(this.slot?.id)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notifications.showSuccessMessage('Slot was successfully deleted');
                    this.goToPage('/availability');
                },
                (error) => {
                    this.notifications.showErrorMessage(error);
                },
            );
    }
}
