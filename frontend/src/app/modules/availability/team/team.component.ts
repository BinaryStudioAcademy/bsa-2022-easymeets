import { Component } from '@angular/core';
import { getDefaultSlots } from '@core/helpers/slots-data-helper';
import { ISlot } from '@core/interfaces/slot/slot-interface';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent {
    public slots: Array<ISlot>;

    constructor() {
        this.slots = getDefaultSlots();
    }
}
