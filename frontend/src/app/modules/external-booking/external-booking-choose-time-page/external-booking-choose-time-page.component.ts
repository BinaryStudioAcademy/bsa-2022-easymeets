import { Component, Input, OnInit } from '@angular/core';
import { getExternalBookingTimeSlotsItems } from '@core/helpers/external-booking-time-slots-helper';
import { IDayTimeSlot } from '@core/models/IDayTimeSlot';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-external-booking-choose-time-page',
    templateUrl: './external-booking-choose-time-page.component.html',
    styleUrls: ['./external-booking-choose-time-page.component.sass'],
})
export class ExternalBookingChooseTimeComponent implements OnInit {
    @Input() selectedUserId: number;

    public selectedUserAvailabilitySlots: IUserPersonalAndTeamSlots;

    public daysWithTimeRange: IDayTimeSlot[] = getExternalBookingTimeSlotsItems();

    public selectedMeetingDuration: number = 60;

    public slotsCount: Array<object>;

    constructor(public spinnerService: SpinnerService, private availabilitySlotService: AvailabilitySlotService) {
        this.availabilitySlotService.getUserPersonalAndTeamSlots(this.selectedUserId).subscribe((slots) => {
            this.selectedUserAvailabilitySlots = slots;
        });
    }

    ngOnInit(): void {
        this.slotsCount = this.slotsCounter();
    }

    private slotsCounter(): Array<object> {
        let theLatestFinishOfTimeRanges: Date = this.daysWithTimeRange[0].finishTime;
        let theEarliestStartOfTimeRanges: Date = this.daysWithTimeRange[0].startTime;

        this.daysWithTimeRange.forEach((day) => {
            if (day.finishTime > theLatestFinishOfTimeRanges) {
                theLatestFinishOfTimeRanges = day.finishTime;
            }
            if (day.startTime < theEarliestStartOfTimeRanges) {
                theEarliestStartOfTimeRanges = day.startTime;
            }
        });

        const theLongestHoursRange: number =
            theLatestFinishOfTimeRanges.getHours() - theEarliestStartOfTimeRanges.getHours();

        return new Array((theLongestHoursRange * 60) / this.selectedMeetingDuration + 1);
    }
}
