import { Clipboard } from '@angular/cdk/clipboard';
import { Component, EventEmitter, HostBinding, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ColorShadowMapping } from '@core/helpers/color-shadow-mapping';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IColorHex } from '@core/models/IColorHex';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { environment } from '@env/environment';
import { activationSlotMessage, deletionMessage, inactivationSlotMessage } from '@shared/constants/shared-messages';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent extends BaseComponent implements OnInit, OnDestroy {
    @Input() slot: IAvailabilitySlot;

    @Input() hasOwner: boolean;

    @Output() isDeleted = new EventEmitter<boolean>();

    @Output() isChangedActivity = new EventEmitter<boolean>();

    locationTypeMapping = LocationTypeMapping;

    ColorShadowMapping = ColorShadowMapping;

    isChecked: boolean = true;

    @HostBinding('style.--slotLineColor') slotLineColor = '';

    @HostBinding('style.--slotShadowColor') slotShadowColor = '';

    private deleteEventEmitter = new EventEmitter<void>();

    private deleteEventSubscription: Subscription;

    private changeActivityEventEmitter = new EventEmitter<void>();

    private changeActivitySubscription: Subscription;

    private activationTitle = 'Confirm Slot Activation';

    private inactivationTitle = 'Confirm Slot Inactivation';

    constructor(
        private http: AvailabilitySlotService,
        private notifications: NotificationService,
        private router: Router,
        private confirmWindowService: ConfirmationWindowService,
        private clipboard: Clipboard,
    ) {
        super();

        this.deleteEventSubscription = this.deleteEventEmitter.subscribe(() => this.deleteSlot());
        this.changeActivitySubscription = this.changeActivityEventEmitter.subscribe(() => this.changeSlotActivity());
    }

    ngOnInit(): void {
        this.isChecked = this.slot.isEnabled;

        const slotLineColorInfo: IColorHex = ColorShadowMapping(this.slot.color);

        this.slotLineColor = slotLineColorInfo.colorHex;
        this.slotShadowColor = slotLineColorInfo.shadowHex;
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
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
        this.http
            .deleteSlot(this.slot.id)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notifications.showSuccessMessage('Slot was successfully deleted');
                    this.isDeleted.emit(true);
                },
                (error) => {
                    this.notifications.showErrorMessage(error);
                },
            );
    }

    public changeSlotActivityClick(event: MatSlideToggleChange) {
        event.source.checked = this.isChecked;

        this.confirmWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Yes',
                    onClickEvent: this.changeActivityEventEmitter,
                },
                {
                    class: 'confirm-cancel-button',
                    label: 'Cancel',
                    onClickEvent: new EventEmitter<void>(),
                },
            ],
            title: event.checked ? this.activationTitle : this.inactivationTitle,
            message: event.checked ? activationSlotMessage : inactivationSlotMessage,
        });
    }

    public changeSlotActivity() {
        this.http
            .updateSlotEnabling(this.slot?.id)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notifications.showSuccessMessage('Slot`s activity was successfully changed');
                    this.isChangedActivity.emit(true);
                },
                (error) => {
                    this.notifications.showErrorMessage(error);
                },
            );
    }

    override ngOnDestroy(): void {
        super.ngOnDestroy();

        this.deleteEventSubscription.unsubscribe();
        this.changeActivitySubscription.unsubscribe();
    }

    public getDefinitionLink() {
        return `${environment.appUrl}/external-booking/choose-time/${this.slot.link}`;
    }

    saveLink() {
        this.clipboard.copy(this.getDefinitionLink());
        this.notifications.showSuccessMessage('Link copied to clipboard');
    }
}
