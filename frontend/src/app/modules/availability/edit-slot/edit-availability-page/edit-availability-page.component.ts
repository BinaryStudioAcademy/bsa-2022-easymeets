import { Component, EventEmitter, HostListener, OnDestroy, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { SlotType } from '@core/enums/slot-type.enum';
import { ComponentCanDeactivate } from '@core/guards/pending-changes.guard';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISaveAvailability } from '@core/models/save-availability-slot/ISaveAvailability';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { NewAvailabilityComponent } from '@modules/availability/new-slot/new-availability/new-availability.component';
import { deletionMessage } from '@shared/constants/shared-messages';
import { Observable, Subscription } from 'rxjs';

@Component({
    selector: 'app-edit-availability-page',
    templateUrl: './edit-availability-page.component.html',
    styleUrls: ['./edit-availability-page.component.sass'],
})
export class EditAvailabilityPageComponent extends BaseComponent implements OnDestroy, ComponentCanDeactivate {
    @HostListener('window:beforeunload')
    canDeactivate(): Observable<boolean> | boolean {
        return this.canRedirect;
    }

    public slot?: IAvailabilitySlot;

    @ViewChild(NewAvailabilityComponent) newAvailabilityComponent: NewAvailabilityComponent;

    private deleteEventEmitter = new EventEmitter<void>();

    private deleteEventSubscription: Subscription;

    private id: bigint | undefined;

    private canRedirect: boolean = false;

    constructor(
        private router: Router,
        private activateRoute: ActivatedRoute,
        private spinnerService: SpinnerService,
        private http: AvailabilitySlotService,
        private notifications: NotificationService,
        private confirmWindowService: ConfirmationWindowService,
    ) {
        super();
        this.activateRoute.params.subscribe((params) => {
            this.id = params['id'];
            this.spinnerService.show();
            this.http
                .getSlotById(this.id)
                .pipe(this.untilThis)
                .subscribe((slotResponse) => {
                    this.slot = slotResponse;
                    this.spinnerService.hide();
                });
        });

        this.deleteEventSubscription = this.deleteEventEmitter.subscribe(() => this.deleteSlot());
    }

    public goToPage(pageName: string) {
        this.canRedirect = true;
        this.router.navigate([`${pageName}`]);
    }

    sendChanges() {
        this.canRedirect = true;
        const general = this.newAvailabilityComponent.generalComponent.settings;

        general.isEnabled = this.newAvailabilityComponent.slot?.isEnabled ?? true;
        general.type = this.newAvailabilityComponent.scheduleComponent.withTeamMembers ? SlotType.Team : SlotType.Personal;
        const advancedSettings = this.newAvailabilityComponent.generalComponent.addAdvanced
            ? this.newAvailabilityComponent.generalComponent.advancedSettings!
            : null;
        const updateAvailability: ISaveAvailability = {
            generalDetails: this.newAvailabilityComponent.generalComponent.settings,
            hasAdvancedSettings: this.newAvailabilityComponent.generalComponent.addAdvanced,
            advancedSettings,
            slotMembers: this.newAvailabilityComponent.scheduleComponent.slotMembers,
            eventDetails: this.newAvailabilityComponent.eventDetailComponent.settings,
            questions: this.newAvailabilityComponent.questionsComponent.questions,
            schedule: this.newAvailabilityComponent.scheduleComponent.schedule,
            templateSettings: this.newAvailabilityComponent.notificationEmailsComponent.settings,
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

    public deleteButtonClick() {
        this.confirmWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Yes',
                    onClickEvent: this.deleteEventEmitter,
                },
                {
                    class: 'confirm-cancel-button',
                    label: 'Cancel',
                    onClickEvent: new EventEmitter<void>(),
                },
            ],
            title: 'Confirm Slot Deletion',
            message: deletionMessage,
        });
    }

    public deleteSlot() {
        this.canRedirect = true;
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

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.deleteEventSubscription.unsubscribe();
    }
}
