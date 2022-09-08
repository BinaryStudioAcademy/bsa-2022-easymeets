import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IAvailabilitySlotMember } from '@core/models/IAvailabilitySlotMember';
import { IExternalBookingSideMenu } from '@core/models/IExtendBookingSideMenu';
import { IExternalAnswers } from '@core/models/IExternalAnswers';
import { IExternalAttendee } from '@core/models/IExternalAttendee';
import { IExternalAttendeeMeeting } from '@core/models/IExternalAttendeeMeeting';
import { IExternalAvailabilitySlot } from '@core/models/IExternalAvailabilitySlot';
import { IExternalMeeting } from '@core/models/IExternalMeeting';
import { ExternalAttendeeService } from '@core/services/external-attendee.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { LocationType } from '@shared/enums/locationType';
import { TZone } from 'moment-timezone-picker';

@Component({
    selector: 'app-external-booking-page',
    templateUrl: './external-booking-page.component.html',
    styleUrls: ['./external-booking-page.component.sass'],
})
export class ExternalBookingPageComponent extends BaseComponent implements OnInit {
    menu: IExternalBookingSideMenu = {} as IExternalBookingSideMenu;

    personalSlots?: IExternalAvailabilitySlot[];

    link: string;

    locationTypeMapping = LocationTypeMapping;

    constructor(
        public spinnerService: SpinnerService,
        private externalService: ExternalAttendeeService,
        private notificationService: NotificationService,
        public router: Router,
        private route: ActivatedRoute,
    ) {
        super();
    }

    ngOnInit(): void {
        if (this.isChooseMeetingRoute()) {
            this.route.firstChild?.paramMap.pipe(this.untilThis).subscribe((params) => {
                this.link = params.get('userLink')!;
            });
            this.getUserAndSlots();
        } else if (this.isBookingChooseTimeRoute()) {
            this.route.firstChild?.paramMap.pipe(this.untilThis).subscribe((params) => {
                this.link = params.get('slotLink')!;
            });
            this.getUser();
        }

        if (this.isTeamBooking()) {
            this.menu = {
                ...this.menu,
                team: {
                    id: 1,
                    image: '',
                    name: 'My Default Team',
                    pageLink: '',
                    timeZone: getDefaultTimeZone(),
                    description: '',
                },
                duration: 30,
                location: LocationType.GoogleMeet,
            };
        }
    }

    public getUser() {
        this.externalService
            .getUserBySlotLink(this.link)
            .pipe(this.untilThis)
            .subscribe(
                (user) => {
                    this.menu = {
                        ...this.menu,
                        user,
                    };
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    public getUserAndSlots() {
        this.externalService
            .getUserAndPersonalSlots(this.link)
            .pipe(this.untilThis)
            .subscribe(
                (response) => {
                    const { user } = response;

                    this.menu = {
                        ...this.menu,
                        user,
                    };

                    this.personalSlots = response.personalSlots;
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    public addDurationAndLocationInMenu(data: {
        slotId: bigint;
        teamId?: bigint;
        duration: number;
        location: LocationType;
    }): void {
        this.menu = {
            ...this.menu,
            duration: data.duration,
            location: data.location,
            slotId: data.slotId,
            teamId: data.teamId,
        };
    }

    public addTimeAndDateInMenu(data: { date: Date; timeFinish: Date; timeZone: TZone }): void {
        this.menu = {
            ...this.menu,
            date: data.date,
            timeFinish: data.timeFinish,
            timeZone: data.timeZone,
        };
    }

    public removeDateAndTime(isBack: boolean) {
        if (isBack) {
            this.menu = {
                ...this.menu,
                date: undefined,
                timeFinish: undefined,
            };
        }
    }

    public addMembersInMenu(selectedMembers: IAvailabilitySlotMember[]) {
        this.menu = {
            ...this.menu,
            teamSlotMembers: selectedMembers,
        };
    }

    public addTeamId(id: bigint) {
        this.menu = {
            ...this.menu,
            teamId: id,
        };
    }

    public confirmBookingByExternalAttendee(answers: IExternalAnswers) {
        const meeting: IExternalMeeting = {
            teamId: this.menu.teamId,
            availabilitySlotId: this.menu.slotId,
            createdBy: this.menu.user.id,
            name: `Meeting with ${answers.externalName}`,
            locationType: this.menu.location,
            duration: this.menu.duration,
            meetingLink: '',
            startTime: this.menu.date,
            createdAt: new Date(),
            updatedAt: new Date(),
        };

        const attendee: IExternalAttendee = {
            availabilitySlotId: this.menu.slotId,
            name: answers.externalName,
            email: answers.externalEmail,
            timeZoneValue: this.menu.timeZone?.timeValue,
            timeZoneName: this.menu.timeZone?.nameValue,
        };

        const attendeeMeeting: IExternalAttendeeMeeting = {
            attendee,
            meeting,
        };

        this.externalService
            .createExternalMeeting(attendeeMeeting)
            .pipe(this.untilThis)
            .subscribe(
                () => {
                    this.notificationService.showSuccessMessage('Meeting successfully created');
                    this.router.navigate(['/availability']);
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    isChooseMeetingRoute(): boolean {
        return this.router.url.includes('/external-booking/choose-meeting');
    }

    isBookingChooseTimeRoute(): boolean {
        return this.router.url.includes('/external-booking/choose-time');
    }

    isConfirmBookingRoute(): boolean {
        return this.router.url.includes('/external-booking/confirm-booking');
    }

    isTeamBooking(): boolean {
        return this.router.url.includes('/team/') || !!this.menu.team;
    }
}
