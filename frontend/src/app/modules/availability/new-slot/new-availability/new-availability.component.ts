import { AfterViewInit, Component, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { FormControlStatus } from '@angular/forms';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { SideMenuGroupTabs } from '@core/interfaces/sideMenu/tabs/sideMenuGroupTabs';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { EventDetailComponent } from '@modules/availability/new-slot/event-detail/event-detail.component';
import { GeneralComponent } from '@modules/availability/new-slot/general/general.component';
import { ScheduleComponent } from '@modules/availability/new-slot/schedule/schedule.component';

import { NotificationEmailsComponent } from '../notification-emails/notification-emails.component';
import { QuestionsComponent } from '../questions/questions.component';

@Component({
    selector: 'app-new-availability',
    templateUrl: './new-availability.component.html',
    styleUrls: ['./new-availability.component.sass'],
})
export class NewAvailabilityComponent extends BaseComponent implements OnInit, AfterViewInit {
    @Input() showDeleteBlock: boolean = true;

    @Input() set slotValue(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.link = value?.link ?? '';
    }

    @Input() slot?: IAvailabilitySlot;

    @Input() title: string;

    @Output() saveChangesClick: EventEmitter<void> = new EventEmitter();

    @Output() cancelClick: EventEmitter<void> = new EventEmitter();

    @Output() deleteClick: EventEmitter<void> = new EventEmitter();

    @ViewChild(GeneralComponent) generalComponent: GeneralComponent;

    @ViewChild(EventDetailComponent) eventDetailComponent: EventDetailComponent;

    @ViewChild(QuestionsComponent) questionsComponent: QuestionsComponent;

    @ViewChild(ScheduleComponent) scheduleComponent: ScheduleComponent;

    @ViewChild(NotificationEmailsComponent) notificationEmailsComponent: NotificationEmailsComponent;

    sideMenuGroups: SideMenuGroupTabs[];

    isActive: boolean = true;

    index: number = 0;

    link: string;

    eventDetailsErrors: boolean = true;

    generalErrors: boolean = true;

    constructor(private router: Router) {
        super();
    }

    ngAfterViewInit(): void {
        this.generalComponent.generalForm.statusChanges?.subscribe((status: FormControlStatus) => {
            this.generalErrors = !this.checkStatus(status);
        });

        this.eventDetailComponent.formGroup.statusChanges?.subscribe((status: FormControlStatus) => {
            if (status === 'PENDING') {
                return;
            }
            this.eventDetailsErrors = !this.checkStatus(status);
        });
    }

    ngOnInit(): void {
        this.initializeSideMenu();
        this.isActive = this.slot?.isEnabled ?? true;
        this.link = this.slot?.link ?? '';
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

    onLinkChange($event: string) {
        this.link = $event;
    }

    public isInvalid() {
        return this.generalErrors || this.eventDetailsErrors;
    }

    private checkStatus(status: FormControlStatus) {
        return status === 'VALID';
    }
}
