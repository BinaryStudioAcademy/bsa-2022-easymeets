import { Component, Input } from '@angular/core';
import { ISlot } from "@core/interfaces/slot/slot-interface";
import { ITeam } from "@core/interfaces/team-interface";
import { IUser } from "@core/interfaces/user/user-interface";

@Component({
    selector: 'app-team',
    templateUrl: './slots-block.component.html',
    styleUrls: ['./slots-block.component.sass'],
})
export class SlotsBlockComponent {
    @Input()
    public availabilitySlots: Array<ISlot>;

    @Input()
    public name: string;

    @Input()
    public link: string;

    @Input()
    public team?: ITeam;

    @Input()
    public author?: IUser;
}
