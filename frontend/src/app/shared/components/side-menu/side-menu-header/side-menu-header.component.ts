import { AfterContentInit, ChangeDetectorRef, Component, forwardRef, TemplateRef, ViewChild } from '@angular/core';

import { SideMenuItemComponent } from '../side-menu-item/side-menu-item.component';

@Component({
    selector: 'app-side-menu-header',
    templateUrl: './side-menu-header.component.html',
    styleUrls: ['./side-menu-header.component.sass'],
    providers: [
        {
            provide: SideMenuItemComponent,
            // eslint-disable-next-line no-use-before-define
            useExisting: forwardRef(() => SideMenuHeaderComponent),
        },
    ],
})
export class SideMenuHeaderComponent implements AfterContentInit {
    @ViewChild(TemplateRef) template: TemplateRef<any>;

    // eslint-disable-next-line no-empty-function
    constructor(private cdr: ChangeDetectorRef) {}

    ngAfterContentInit(): void {
        this.cdr.detectChanges();
    }
}
