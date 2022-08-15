import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from "rxjs";

@Component({
    selector: 'app-edit-availability-page',
    templateUrl: './edit-availability-page.component.html',
    styleUrls: ['./edit-availability-page.component.sass'],
})
export class EditAvailabilityPageComponent {
    private id: number | undefined;

    private subscription: Subscription;

    // eslint-disable-next-line no-empty-function
    constructor(private router: Router, private activateRoute: ActivatedRoute) {
        this.subscription = activateRoute.params.subscribe(params => {
            this.id = params['id'];
            console.log(this.id);
        });
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }
}
