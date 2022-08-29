import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { SideMenuGroupTabs } from '@core/interfaces/sideMenu/tabs/sideMenuGroupTabs';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { EventDetailComponent } from '@modules/availability/new-slot/event-detail/event-detail.component';
import { GeneralComponent } from '@modules/availability/new-slot/general/general.component';
import { ScheduleComponent } from '@modules/availability/new-slot/schedule/schedule.component';

import { NotificationEmailsComponent } from '../notification-emails/notification-emails.component';

@Component({
    selector: 'app-new-availability',
    templateUrl: './new-availability.component.html',
    styleUrls: ['./new-availability.component.sass'],
})
export class NewAvailabilityComponent implements OnInit {
    @Input() showDeleteBlock: boolean = true;

    @Input() slot?: IAvailabilitySlot;

    @Input() title: string;

    @Output() saveChangesClick: EventEmitter<void> = new EventEmitter();

    @Output() cancelClick: EventEmitter<void> = new EventEmitter();

    @Output() deleteClick: EventEmitter<void> = new EventEmitter();

    @ViewChild(GeneralComponent) generalComponent: GeneralComponent;

    @ViewChild(EventDetailComponent) eventDetailComponent: EventDetailComponent;

    @ViewChild(ScheduleComponent) scheduleComponent: ScheduleComponent;

    @ViewChild(NotificationEmailsComponent) notificationEmailsComponent: NotificationEmailsComponent;

    sideMenuGroups: SideMenuGroupTabs[];

    isActive: boolean = true;

    readonly generalIndex: number = 0;

    readonly bookingPageIndex: number = 1;

    readonly scheduleIndex: number = 2;

    readonly notificationEmailsIndex: number = 3;

    index: number = 0;

    // eslint-disable-next-line no-empty-function
    constructor(private router: Router) {}

    ngOnInit(): void {
        this.initializeSideMenu();
        this.isActive = this.slot?.isEnabled ?? true;
    }

    goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    enableSlot() {
        if (this.slot) {
            this.slot.isEnabled = !this.slot.isEnabled;
        }
    }

    saveChanges() {
        if (this.generalComponent.generalForm.invalid) {
            return;
        }

        this.saveChangesClick.emit();
    }

    private initializeSideMenu() {
        this.sideMenuGroups = getNewAvailabilityMenu();
    }
}
