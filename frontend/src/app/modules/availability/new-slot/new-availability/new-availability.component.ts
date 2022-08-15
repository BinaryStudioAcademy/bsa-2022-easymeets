import { Component, Input, OnInit } from '@angular/core';
import { getNewAvailabilityMenu } from '@core/helpers/new-availability-menu-helper';
import { SideMenuGroup } from '@core/interfaces/sideMenu/sideMenuGroup';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-new-availability',
    templateUrl: './new-availability.component.html',
    styleUrls: ['./new-availability.component.sass'],
})
export class NewAvailabilityComponent implements OnInit {
    @Input() public currentSlot: IAvailabilitySlot;

    public sideMenuGroups: SideMenuGroup[];

    public isActive: boolean = true;

    private unsubscribe$ = new Subject<void>();

    // eslint-disable-next-line no-empty-function
    constructor(private http: AvailabilitySlotService) {}

    ngOnInit(): void {
        this.initializeSideMenu();
    }

    private initializeSideMenu() {
        this.sideMenuGroups = getNewAvailabilityMenu();
    }

    public deleteSlot() {
        this.http
            .deleteSlot(this.currentSlot.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((error) => console.log(error));
    }
}
