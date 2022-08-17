import { Component, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IAvailabilitySlot } from '@core/models/IAvailiabilitySlot';
import { HttpInternalService } from '@core/services/http-internal.service';
import { SpinnerService } from '@core/services/spinner.service';
import { NewAvailabilityComponent } from '@modules/availability/new-slot/new-availability/new-availability.component';

@Component({
    selector: 'app-edit-availability-page',
    templateUrl: './edit-availability-page.component.html',
    styleUrls: ['./edit-availability-page.component.sass'],
})
export class EditAvailabilityPageComponent {
    private id: number | undefined;

    public slot?: IAvailabilitySlot;

    @ViewChild(NewAvailabilityComponent) newAvailabilityComponent: NewAvailabilityComponent;

    // eslint-disable-next-line no-empty-function
    constructor(
        private router: Router,
        private activateRoute: ActivatedRoute,
        private httpInternalService: HttpInternalService,
        private spinnerService: SpinnerService,
    ) {
        this.activateRoute.params.subscribe(params => {
            this.id = params['id'];
            this.spinnerService.show();
            this.httpInternalService
                .getRequest<IAvailabilitySlot>(`/availability/slot/${this.id}`)
                .subscribe(slotResponse => {
                    this.slot = slotResponse;
                    this.spinnerService.hide();
                });
        });
    }

    public goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    sendChanges() {
        this.httpInternalService.putRequest<IAvailabilitySlot>(`/availability/${this.slot?.id}`, {
            generalDetailsUpdate: this.newAvailabilityComponent.generalComponent.settings,
            eventDetailsUpdate: this.newAvailabilityComponent.eventDetailComponent.settings,
            hasAdvancedSettings: this.newAvailabilityComponent.generalComponent.addAdvanced,
            isActive: this.newAvailabilityComponent.slot?.isEnabled ?? true
        }).subscribe(resp => {
            console.log('resp')
            console.log(resp)
            console.log(this.newAvailabilityComponent.generalComponent.settings)
        });
        this.goToPage('/availability');
    }
}
