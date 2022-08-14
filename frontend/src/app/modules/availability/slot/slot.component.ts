import { Component, Input } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { Router } from '@angular/router';
import { ISlot } from '@core/interfaces/slot/slot-interface';
import { ITeam } from "@core/interfaces/team-interface";
import { IUser } from "@core/interfaces/user/user-interface";
import { SlotType } from "@core/enums/slot-type.enum";

@Component({
    selector: 'app-slot',
    templateUrl: './slot.component.html',
    styleUrls: ['./slot.component.sass'],
})
export class SlotComponent {
    @Input() public slot: ISlot;

    @Input() public team?: ITeam;

    @Input() public author?: IUser;

    public isChecked: boolean = true;

    public isDisabled: boolean = false;

    // eslint-disable-next-line no-empty-function
    constructor(private router: Router) { }

    public toggle(event: MatSlideToggleChange) {
        this.isChecked = event.checked;
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    private getTeamSlotMessage(): string {
        return `${this.slot?.members?.length ?? 0} of ${this.team?.members?.length ?? 0} team members`
            + (this.slot?.members?.length === this.team?.members?.length
                ? ' together'
                : '');
    }

    private getUserSlotMessage(): string {
        return this.author?.userName ?? '';
    }

    public getCardText(): string {
        return this.slot.type == SlotType.Personal
            ? this.getUserSlotMessage()
            : this.getTeamSlotMessage();
    }
}
