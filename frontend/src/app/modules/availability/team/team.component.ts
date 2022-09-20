import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { Color } from '@core/enums/color.enum';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IAvailabilitySlotsGroupByTeamsDto } from '@core/models/IAvailabilitySlotsGroupByTeam';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { LocationType } from '@shared/enums/locationType';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent extends BaseComponent implements OnInit {
    @Input() public teamSlot: IAvailabilitySlotsGroupByTeamsDto;

    @Output() isReload = new EventEmitter<boolean>();

    public slots: Array<IAvailabilitySlot>;

    public teamName: string;

    constructor(private router: Router) {
        super();
    }

    ngOnInit(): void {
        this.teamSlot = {
            id: 100n,
            name: 'CorgiTeam',
            image: '',
            availabilitySlots: [
                {
                    id: 103n,
                    teamId: 63n,
                    name: 'TeamSlot',
                    authorName: '',
                    size: 5,
                    link: 'link',
                    isEnabled: true,
                    isVisible: true,
                    locationType: LocationType.GoogleMeet,
                    welcomeMessage: 'welcomeMessage',
                    color: Color.Cyan,
                    language: 'language',
                    bookingsPerDay: 10,
                    passwordProtectionIsUsed: false,
                    timeZoneVisibility: false,
                    questions: [],
                    schedule: {} as ISchedule,
                    members: [
                        { id: 100n, name: 'Member1' },
                        { id: 101n, name: 'Member2' },
                        { id: 102n, name: 'Member3' },
                    ],
                },
            ],
        };
        this.slots = this.teamSlot.availabilitySlots;
        this.teamName = this.teamSlot.name;
    }

    isDeleted(isRemove: boolean) {
        this.isReload.emit(isRemove);
    }

    isChangedActivity(isChanged: boolean) {
        this.isReload.emit(isChanged);
    }

    goToPage(teamId: bigint) {
        this.router.navigate([`settings/teams/edit/${teamId}`]);
    }
}
