import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-edit-availability-page',
    templateUrl: './edit-availability-page.component.html',
    styleUrls: ['./edit-availability-page.component.sass'],
})
export class EditAvailabilityPageComponent {
    // eslint-disable-next-line no-empty-function
    constructor(private router: Router) { }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
