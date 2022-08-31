import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ISaveAvailability } from '@core/models/save-availability-slot/ISaveAvailability';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { NewAvailabilityComponent } from '@modules/availability/new-slot/new-availability/new-availability.component';

@Component({
    selector: 'app-new-availability-page',
    templateUrl: './new-availability-page.component.html',
    styleUrls: ['./new-availability-page.component.sass'],
})
export class NewAvailabilityPageComponent extends BaseComponent {
    constructor(
        private router: Router,
        private slotService: AvailabilitySlotService,
        private notifications: NotificationService,
        private teamService: TeamService,
    ) {
        super();
        teamService.currentTeamEmitted$.subscribe((teamId) => {
            this.currentTeamId = teamId;
        });
    }

    @ViewChild(NewAvailabilityComponent) newAvailabilityComponent: NewAvailabilityComponent;

    currentTeamId?: number;

    goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    saveChanges() {
        const newSlot = this.getNewAvailability();

        this.slotService
            .createSlot(newSlot)
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

    private getNewAvailability() {
        const general = this.newAvailabilityComponent.generalComponent.settings;

        general.isEnabled = this.newAvailabilityComponent.isActive;
        const advancedSettings = this.newAvailabilityComponent.generalComponent.addAdvanced
            ? this.newAvailabilityComponent.generalComponent.advancedSettings!
            : null;
        const newAvailability: ISaveAvailability = {
            generalDetails: general,
            advancedSettings,
            eventDetails: this.newAvailabilityComponent.eventDetailComponent.settings,
            questions: this.newAvailabilityComponent.questionsComponent.questions,
            schedule: this.newAvailabilityComponent.scheduleComponent.schedule,
            templateSettings: this.newAvailabilityComponent.notificationEmailsComponent.settings,
            teamId: this.currentTeamId ?? 3,
            hasAdvancedSettings: this.newAvailabilityComponent.generalComponent.addAdvanced,
        };

        return newAvailability;
    }
}
