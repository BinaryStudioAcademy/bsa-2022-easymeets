import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { SlotType } from '@core/enums/slot-type.enum';
import { INewAvailability } from '@core/models/new-availability-slot/INewAvailability';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { NewAvailabilityComponent } from '@modules/availability/new-slot/new-availability/new-availability.component';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'app-new-availability-page',
    templateUrl: './new-availability-page.component.html',
    styleUrls: ['./new-availability-page.component.sass'],
})
export class NewAvailabilityPageComponent {
    constructor(
        private router: Router,
        private slotService: AvailabilitySlotService,
        private notifications: NotificationService,
        // eslint-disable-next-line no-empty-function
    ) { }

    private unsubscribe$ = new Subject<void>();

    @ViewChild(NewAvailabilityComponent) newAvailabilityComponent: NewAvailabilityComponent;

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    public saveChanges() {
        const newSlot = this.getNewAvailability();

        this.slotService.createSlot(newSlot)
            .pipe(takeUntil(this.unsubscribe$))
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

    private getNewAvailability() {
        const general = this.newAvailabilityComponent.generalComponent.settings;
        const eventDetails = this.newAvailabilityComponent.eventDetailComponent.settings;
        const advancedSettings = this.newAvailabilityComponent.generalComponent.addAdvanced
            ? {
                activityType: general.slotActivityOption,
                days: general.slotSize,
                maxNumberOfBookings: general.maxBookings,
                paddingMeeting: general.meetingPadding,
                minBookingMeetingDifference: general.minBookingMeetingDifference,
                color: general.color,
            } : null;
        const newAvailability: INewAvailability = {
            generalDetails: {
                locationType: general.meetingLocation,
                name: general.meetingName,
                type: SlotType.Personal,
                size: general.slotSize,
                frequency: general.slotFrequency,
                isEnabled: this.newAvailabilityComponent.isActive,
                isVisible: general.hideFromCommon,
            },
            eventDetails: {
                link: eventDetails.linkChoice,
                welcomeMessage: eventDetails.welcomeMessage,
                language: eventDetails.languageSelect,
                bookingsPerDay: eventDetails.allowBookingSelect,
                allowToAddGuests: eventDetails.isAllowBooker,
                passwordProtectionIsUsed: eventDetails.passwordProtect,
                passwordProtection: eventDetails.passwordInput,
                timeZoneVisibility: eventDetails.zoneChoice,
            },
            advancedSettings,
            schedule: this.newAvailabilityComponent.scheduleComponent.schedule,
            teamId: 1,
            hasAdvancedSettings: this.newAvailabilityComponent.generalComponent.addAdvanced,
        };

        return newAvailability;
    }
}
