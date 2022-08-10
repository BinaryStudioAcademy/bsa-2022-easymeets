import { AfterContentInit, ChangeDetectorRef, Component, EventEmitter, TemplateRef, ViewChild } from '@angular/core';

@Component({
    selector: 'app-side-menu-item',
    templateUrl: './side-menu-item.component.html',
    styleUrls: ['./side-menu-item.component.sass'],
})
export class SideMenuItemComponent implements AfterContentInit {
    public isSelected: boolean = false;

    @ViewChild(TemplateRef) template: TemplateRef<any>;

    // eslint-disable-next-line no-use-before-define
    public toggleHandler: EventEmitter<SideMenuItemComponent> = new EventEmitter<SideMenuItemComponent>();

    // eslint-disable-next-line no-empty-function
    constructor(private cdr: ChangeDetectorRef) {}

    ngAfterContentInit(): void {
        this.cdr.detectChanges();
    }

    public toggleSelection() {
        this.isSelected = !this.isSelected;
    }

    public click() {
        this.toggleHandler.emit(this);
    }
}
