import { Component } from '@angular/core';
import { Slot } from '@core/interfaces/slot-interface';

import * as data from 'src/app/core/helpers/slots-data-helper';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent {
    public slots: Array<Slot>;

    constructor() {
        const { getDefaultSlots } = data;

        this.slots = getDefaultSlots();
    }
}
