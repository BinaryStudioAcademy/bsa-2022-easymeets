import { AfterViewInit, Component } from '@angular/core';
import { ISlotsResponse } from '@core/interfaces/slot/slots-response';
import { HttpInternalService } from '@core/services/http-internal.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent implements AfterViewInit {
    public slotsResponse?: ISlotsResponse;

    constructor(private httpInternalService: HttpInternalService, private spinnerService: SpinnerService) { }

    public ngAfterViewInit() {
        this.spinnerService.show();
        this.httpInternalService
            .getRequest<ISlotsResponse>('/availability')
            .subscribe(slotsResponse => {
                console.log(slotsResponse);
                this.slotsResponse = slotsResponse;
                this.spinnerService.hide();
            });
    }
}
