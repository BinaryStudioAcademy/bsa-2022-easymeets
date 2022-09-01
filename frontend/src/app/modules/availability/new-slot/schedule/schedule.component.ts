import { Clipboard } from '@angular/cdk/clipboard';
import { Component, EventEmitter, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { BaseComponent } from '@core/base/base.component';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { NotificationService } from '@core/services/notification.service';
import { environment } from '@env/environment';

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

    @Input() public slotLink: string;

    changeEvent: EventEmitter<any> = new EventEmitter();

    slot?: IAvailabilitySlot;

    schedule: ISchedule;

    constructor(private notificationsService: NotificationService, private clipboard: Clipboard) {
        super();
    }

    public externalDefinitionToggle($event: MatSlideToggleChange) {
        if (!this.schedule.definedExternally && !this.slotLink) {
            this.notificationsService.showInfoMessage('Slot link must be defined and unique to allow external schedule definition');
            $event.source.checked = false;

            return;
        }
        this.schedule = getDefaultSchedule(!this.schedule.definedExternally);
        $event.source.checked = this.schedule.definedExternally;
    }

    public getDefinitionLink() {
        return `${environment.appUrl}/slotdefining/${this.slotLink}`;
    }

    saveLink() {
        this.clipboard.copy(this.getDefinitionLink());
        this.notificationsService.showSuccessMessage('Link copied to clipboard');
    }
}
