import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-new-availability-page',
    templateUrl: './new-availability-page.component.html',
    styleUrls: ['./new-availability-page.component.sass'],
})
export class NewAvailabilityPageComponent {
    // eslint-disable-next-line no-empty-function
    constructor(private router: Router) { }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
