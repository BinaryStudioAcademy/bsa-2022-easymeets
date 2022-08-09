import { Component } from '@angular/core';
import { SlotsDataHelper } from '@core/helpers/slots-data-helper';
import { Slot } from '@core/interfaces/slot-interface';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent {
    public slots: Array<Slot> = SlotsDataHelper.slots;
}
