import { Component, Input } from '@angular/core';
import { IUserMeeting } from '@core/models/IUserMeeting';

@Component({
    selector: 'app-booker',
    templateUrl: './booker.component.html',
    styleUrls: ['./booker.component.sass'],
})
export class BookerComponent {
    @Input() public booker: IUserMeeting;
}
