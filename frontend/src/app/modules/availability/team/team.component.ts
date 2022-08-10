import { Component } from '@angular/core';
import { getDefaultSlots } from '@core/helpers/slots-data-helper';
import { Slot } from '@core/interfaces/slot-interface';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent {
    public slots: Array<Slot>;

    constructor() {
        this.slots = getDefaultSlots();
    }
}
