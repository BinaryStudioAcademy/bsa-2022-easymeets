import { Component, EventEmitter, Output } from '@angular/core';

@Component({
    selector: 'app-external-booking-confirmed-page',
    templateUrl: './external-booking-confirmed-page.component.html',
    styleUrls: ['./external-booking-confirmed-page.component.sass'],
})
export class ExternalBookingConfirmedComponent {
    @Output() anotherMeetingEvent = new EventEmitter<boolean>();

    onChooseAnotherMeeting() {
        this.anotherMeetingEvent.emit();
    }
}
