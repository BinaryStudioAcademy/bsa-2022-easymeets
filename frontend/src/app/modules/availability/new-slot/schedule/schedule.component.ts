import { Clipboard } from '@angular/cdk/clipboard';
import { Component, EventEmitter, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { BaseComponent } from '@core/base/base.component';
import { getAppDomain } from '@core/helpers/app-domain-helper';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { NotificationService } from '@core/services/notification.service';

@Component({
    selector: 'app-schedule',
    templateUrl: './schedule.component.html',
    styleUrls: ['./schedule.component.sass'],
})
export class ScheduleComponent extends BaseComponent {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.schedule = this.slot?.schedule ?? getDefaultSchedule(false);
    }

    constructor(private notificationsService: NotificationService, private clipboard: Clipboard) {
        super();
    }

    @Input() public slotLink: string;

    public externalDefinitionToggle($event: MatSlideToggleChange) {
        if (!this.schedule.definedExternally && !this.slotLink) {
            this.notificationsService.showInfoMessage('Slot link must be defined and unique to allow external schedule definition');
            $event.source.checked = false;

            return;
        }
        this.schedule.definedExternally = !this.schedule.definedExternally;
        this.schedule = getDefaultSchedule(this.schedule.definedExternally);
        $event.source.checked = this.schedule.definedExternally;
    }

    public getDefinitionLink() {
        return `${getAppDomain()}slotdefining/${this.slotLink}`;
    }

    changeEvent: EventEmitter<any> = new EventEmitter();

    slot?: IAvailabilitySlot;

    schedule: ISchedule;

    saveLink() {
        this.clipboard.copy(this.getDefinitionLink());
        this.notificationsService.showSuccessMessage('Link copied to clipboard');
    }
}
