import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { SlotType } from '@core/enums/slot-type.enum';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IExternalBookingSideMenu } from '@core/models/IExtendBookingSideMenu';
import { IExternalAttendee } from '@core/models/IExternalAttendee';
import { IExternalAttendeeMeeting } from '@core/models/IExternalAttendeeMeeting';
import { IExternalAvailabilitySlot } from '@core/models/IExternalAvailabilitySlot';
import { IExternalMeeting } from '@core/models/IExternalMeeting';
import { IExternalUser } from '@core/models/IExternalUser';
import { IQuestion } from '@core/models/IQuestion';
import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';
import { ExternalAttendeeService } from '@core/services/external-attendee.service';
import { NotificationService } from '@core/services/notification.service';
import { SpinnerService } from '@core/services/spinner.service';
import { TeamService } from '@core/services/team.service';
import { LocationType } from '@shared/enums/locationType';
import { SlotParticipationOption } from '@shared/enums/slotParticipationOption';
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

    isUserBooking: boolean;

    locationTypeOffice = LocationType.Office;

    slotDataLoaded: boolean = false;

    locationTypeMapping = LocationTypeMapping;

    maxAvatarNumber: number = 10;

    constructor(
        public spinnerService: SpinnerService,
        private externalService: ExternalAttendeeService,
        private notificationService: NotificationService,
        public router: Router,
        private route: ActivatedRoute,
        private teamService: TeamService,
    ) {
        super();
    }

    ngOnInit(): void {
        if (this.isChooseMeetingRoute()) {
            this.loadDataByUserLink();
        } else if (this.isBookingChooseTimeRoute()) {
            this.loadDataBySlotLink();
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

        this.isUserBooking = this.isChooseMeetingRoute();
    }

    public getUser() {
        this.externalService
            .getUserBySlotLink(this.link)
            .pipe(this.untilThis)
            .subscribe(
                (user) => {
                    this.addUserToMenu(user);
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
                    this.addUserToMenu(response.user);
                    this.personalSlots = response.personalSlots;
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    public addUserToMenu(user: IExternalUser) {
        this.menu = {
            ...this.menu,
            user,
        };
    }

    public addDurationAndLocationInMenu(data: {
        slotId: bigint;
        teamId?: bigint;
        duration: number;
        location: LocationType;
        questions: IQuestion[];
        meetingRoom?: string;
        name: string;
        slotType?: SlotType;
        participationRule?: SlotParticipationOption;
        slotMembers: ISlotMember[]
    }): void {
        this.menu = {
            ...this.menu,
            duration: data.duration,
            location: data.location,
            meetingRoom: data.meetingRoom,
            slotId: data.slotId,
            teamId: data.teamId,
            slotName: data.name,
            questions: data.questions,
            slotType: data.slotType,
            participationRule: data.participationRule,
            slotMembers: this.slotDataLoaded ? this.menu.slotMembers : data.slotMembers,
        };
        this.getTeam();
        if (this.menu.slotType === SlotType.Team &&
            this.menu.participationRule === SlotParticipationOption.One &&
            data.slotMembers.length > 1 &&
            !this.slotDataLoaded) {
            this.router.navigate(['/external-booking/choose-team-members']);
        } else {
            this.slotDataLoaded = true;
        }
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

    public reloadData(reloadLink: string) {
        this.menu = {
            ...this.menu,
            duration: undefined,
            location: undefined,
        };
        this.link = reloadLink;
        this.getUserAndSlots();
    }

    public selectSLotMember(member: ISlotMember) {
        this.menu = {
            ...this.menu,
            slotMembers: [member],
        };
        this.slotDataLoaded = true;
        this.router.navigate([`/external-booking/choose-time/${this.link}`]);
    }

    public addTeamId(id: bigint) {
        this.menu = {
            ...this.menu,
            teamId: id,
        };
    }

    public confirmBookingByExternalAttendee(userAnswers: IQuestion[]) {
        const meeting: IExternalMeeting = {
            teamId: this.menu.teamId,
            availabilitySlotId: this.menu.slotId,
            createdBy: this.menu.user.id,
            name: `Meeting with ${userAnswers[0].answer}`,
            answers: userAnswers,
            locationType: this.menu.location,
            meetingRoom: this.menu.meetingRoom,
            duration: this.menu.duration,
            meetingLink: '',
            startTime: this.menu.date,
            createdAt: new Date(),
            updatedAt: new Date(),
            members: this.menu.slotMembers,
        };

        const attendee: IExternalAttendee = {
            availabilitySlotId: this.menu.slotId,
            name: userAnswers[0].answer,
            email: userAnswers[1].answer,
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
                    this.router.navigate(['/external-booking/confirmed-booking']);
                },
                (error) => {
                    this.notificationService.showErrorMessage(error);
                },
            );
    }

    loadDataByUserLink() {
        this.route.firstChild?.paramMap.pipe(this.untilThis).subscribe((params) => {
            this.link = params.get('userLink')!;
        });
        this.getUserAndSlots();
    }

    loadDataBySlotLink() {
        this.route.firstChild?.paramMap.pipe(this.untilThis).subscribe((params) => {
            this.link = params.get('slotLink')!;
        });
        this.getUser();
    }

    bookAnotherMeeting() {
        const navigationURL: string = this.isUserBooking
            ? `/external-booking/choose-meeting/${this.link}`
            : `/external-booking/choose-time/${this.link}`;

        this.router.navigateByUrl(navigationURL);
        this.clearMeetingDetails();
    }

    clearMeetingDetails() {
        this.menu = {
            ...this.menu,
            slotName: this.isUserBooking ? undefined : this.menu.slotName,
        };

        delete this.menu.duration;
        delete this.menu.location;
        delete this.menu.timeFinish;
        delete this.menu.date;
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
        return this.menu.slotType === SlotType.Team && !!this.menu.team;
    }

    isConfirmedRoute(): boolean {
        return this.router.url.includes('/external-booking/confirmed-booking');
    }

    isChooseMembersRoute(): boolean {
        return this.router.url.includes('/external-booking/choose-team-members');
    }

    private getTeam() {
        this.teamService.getTeamById(Number(this.menu.teamId))
            .pipe(this.untilThis)
            .subscribe(team => {
                this.menu.team = team;
            });
    }
}
