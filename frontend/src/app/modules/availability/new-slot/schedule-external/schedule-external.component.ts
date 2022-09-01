import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ExternalScheduleState } from '@core/enums/external-schedule-state.enum';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { emailRegex } from '@shared/constants/model-validation';

@Component({
    selector: 'app-schedule-external',
    templateUrl: './schedule-external.component.html',
    styleUrls: ['./schedule-external.component.sass'],
})
export class ScheduleExternalComponent extends BaseComponent {
    public state: ExternalScheduleState = ExternalScheduleState.ScheduleDefining;

    public link: string;

    public slot?: IAvailabilitySlot;

    public schedule: ISchedule = getDefaultSchedule(true);

    public emailPattern = emailRegex;

    constructor(
        private router: Router,
        private activatedRoute: ActivatedRoute,
        private notificationsService: NotificationService,
        private slotService: AvailabilitySlotService,
    ) {
        super();
        activatedRoute.params.subscribe(params => {
            this.link = params['link'];
            this.getSlotFromLink();
        });
    }

    private getSlotFromLink() {
        this.slotService.getByLink(this.link)
            .pipe(this.untilThis)
            .subscribe(slot => {
                if (!slot) {
                    this.notificationsService.showErrorMessage('Link is invalid or not unique');
                    this.router.navigate(['/availability']);

                    return;
                }
                this.slot = slot;
                this.schedule = {
                    ...slot.schedule,
                    scheduleItems: getScheduleItems(),
                };
            });
    }

    public nextClicked() {
        this.state = ExternalScheduleState.EmailDefining;
    }

    public doneClicked() {
        this.slotService.updateScheduleExternally(this.link, this.schedule)
            .pipe(this.untilThis)
            .subscribe(() => {
                this.state = ExternalScheduleState.Done;
            }, () => {
                this.notificationsService.showErrorMessage('Something went wrong, try defining schedule again');
                this.returnToSchedule();
            });
    }

    public returnToSchedule() {
        this.state = ExternalScheduleState.ScheduleDefining;
    }
}
