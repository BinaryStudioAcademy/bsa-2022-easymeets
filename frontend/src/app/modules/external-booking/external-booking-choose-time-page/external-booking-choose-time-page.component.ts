import { Component, Input, OnInit } from '@angular/core';
import { getExternalBookingTimeSlotsItems } from '@core/helpers/external-booking-time-slots-helper';
import { ICalendarWeek } from '@core/models/ICalendarWeek';
import { IDayTimeSlot } from '@core/models/IDayTimeSlot';
import { IUserPersonalAndTeamSlots } from '@core/models/IUserPersonalAndTeamSlots';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TimeZone } from '@shared/enums/timeZone';

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

    public theLatestFinishOfTimeRanges: Date;

    public theEarliestStartOfTimeRanges: Date;

    public timeZone = TimeZone;

    public calendarWeek: ICalendarWeek;

    public nowDate: Date = new Date(Date.now());

    constructor(public spinnerService: SpinnerService, private availabilitySlotService: AvailabilitySlotService) {
        this.availabilitySlotService.getUserPersonalAndTeamSlots(this.selectedUserId).subscribe((slots) => {
            this.selectedUserAvailabilitySlots = slots;
        });
    }

    ngOnInit(): void {
        this.slotsCount = this.slotsCounter();
        this.calendarWeek = this.getCurrentWeek();
    }

    private slotsCounter(): Array<object> {
        this.theLatestFinishOfTimeRanges = this.daysWithTimeRange[0].finishTime;
        this.theEarliestStartOfTimeRanges = this.daysWithTimeRange[0].startTime;

        this.daysWithTimeRange.forEach((day) => {
            if (day.finishTime > this.theLatestFinishOfTimeRanges) {
                this.theLatestFinishOfTimeRanges = day.finishTime;
            }
            if (day.startTime < this.theEarliestStartOfTimeRanges) {
                this.theEarliestStartOfTimeRanges = day.startTime;
            }
        });

        const theLongestHoursRange: number =
            this.theLatestFinishOfTimeRanges.getHours() - this.theEarliestStartOfTimeRanges.getHours();

        return new Array((theLongestHoursRange * 60) / this.selectedMeetingDuration + 1);
    }

    private getCurrentWeek(): ICalendarWeek {
        const current = new Date();
        const first = current.getDate() - current.getDay() + 1;
        const last = first + 6;

        const firstDay: Date = new Date(current.setDate(first));
        const lastDay: Date = new Date(current.setDate(last));

        const week: ICalendarWeek = { firstDay, lastDay };

        return week;
    }

    public changeWeek(addingMode: boolean): void {
        if (addingMode) {
            this.calendarWeek.firstDay = new Date(
                this.calendarWeek.firstDay.setDate(this.calendarWeek.firstDay.getDate() + 7),
            );
            this.calendarWeek.lastDay = new Date(
                this.calendarWeek.lastDay.setDate(this.calendarWeek.lastDay.getDate() + 7),
            );
        } else {
            this.calendarWeek.firstDay = new Date(
                this.calendarWeek.firstDay.setDate(this.calendarWeek.firstDay.getDate() - 7),
            );
            this.calendarWeek.lastDay = new Date(
                this.calendarWeek.lastDay.setDate(this.calendarWeek.lastDay.getDate() - 7),
            );
        }
    }
}
