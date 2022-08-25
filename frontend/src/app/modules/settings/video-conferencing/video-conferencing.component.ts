import { Component } from '@angular/core';
import { ZoomService } from '@core/services/zoom.service';

@Component({
    selector: 'app-video-conferencing',
    templateUrl: './video-conferencing.component.html',
    styleUrls: ['./video-conferencing.component.sass'],
})
export class VideoConferencingComponent {
    // eslint-disable-next-line no-empty-function
    constructor(private zoomService: ZoomService) {}

    public connectZoom() {
        this.zoomService.authorizeUser();
    }
}
