import { Clipboard } from '@angular/cdk/clipboard';
import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { BaseComponent } from '@core/base/base.component';
import { SlotType } from '@core/enums/slot-type.enum';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getParticipationOptions, getScheduleModes } from '@core/helpers/schedule-mode-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { UserService } from '@core/services/user.service';
import { environment } from '@env/environment';
import { SlotParticipationOption } from '@shared/enums/slotParticipationOption';
import { SlotScheduleMode } from '@shared/enums/slotScheduleMode';
import { filter, map, switchMap } from 'rxjs';

@Component({
    selector: 'app-schedule',
    templateUrl: './schedule.component.html',
    styleUrls: ['./schedule.component.sass'],
})
export class ScheduleComponent extends BaseComponent implements OnInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.schedule = this.slot?.schedule ?? getDefaultSchedule(false);
        this.refreshMembers();
        this.withTeamMembers = this.slot?.type === SlotType.Team;
        this.slotLink = this.slot?.link ?? '';
        this.selectedParticipationOption = this.slot?.participationRule ?? SlotParticipationOption.All;
    }

    @Input() public slotLink: string;

    teamId: number;

    selectedScheduleMode: SlotScheduleMode = SlotScheduleMode.OneForAll;

    scheduleModes: SlotScheduleMode[] = getScheduleModes();

    selectedParticipationOption: SlotParticipationOption = SlotParticipationOption.All;

    participationOptions: SlotParticipationOption[] = getParticipationOptions();

    changeEvent: EventEmitter<any> = new EventEmitter();

    slot?: IAvailabilitySlot;

    defaultMember: ISlotMember;

    schedule: ISchedule;

    slotMembers: ISlotMember[] = [];

    withTeamMembers: boolean = false;

    onAddEvent: EventEmitter<ISlotMember[]> = new EventEmitter<ISlotMember[]>();

    constructor(
        private notificationsService: NotificationService,
        private clipboard: Clipboard,
        private userService: UserService,
        private teamService: TeamService,
        private confirmationService: ConfirmationWindowService,
    ) {
        super();
    }

    public ngOnInit() {
        this.getDefaultMember().pipe(switchMap(() => this.getCurrentTeamId())).subscribe();
        this.onAddEvent.pipe(this.untilThis).subscribe(members => this.addSlotMembers(members));
    }

    public externalDefinitionToggle($event: MatSlideToggleChange) {
        if (!this.schedule.definedExternally && !this.slotLink) {
            this.notificationsService.showInfoMessage(
                'Slot link must be defined and unique to allow external schedule definition',
            );
            $event.source.checked = false;

            return;
        }
        this.schedule = getDefaultSchedule(!this.schedule.definedExternally);
        $event.source.checked = this.schedule.definedExternally;
    }

    public getDefinitionLink() {
        return `${environment.appUrl}/slotdefining/${this.slotLink}`;
    }

    public saveLink() {
        this.clipboard.copy(this.getDefinitionLink());
        this.notificationsService.showSuccessMessage('Link copied to clipboard');
    }

    public removeMember(member: ISlotMember) {
        this.slotMembers = this.slotMembers.filter(m => m.memberId !== member.memberId);
    }

    public withMembersChange() {
        if (!this.withTeamMembers) {
            this.slotMembers = [this.defaultMember];
        }
    }

    public openAddMembers() {
        this.confirmationService.openSlotMembersDialog({
            alreadySelected: this.slotMembers,
            teamId: this.teamId,
            onAddEvent: this.onAddEvent,
        });
    }

    public addSlotMembers(members: ISlotMember[]) {
        this.slotMembers = [...this.slotMembers, ...members];
    }

    public getParticipationText(role: SlotParticipationOption) {
        return role === SlotParticipationOption.All
            ? 'All Added Members Together'
            : 'Booker chooses one member';
    }

    private refreshMembers() {
        this.slotMembers = this.slot?.slotMembers ?? [this.defaultMember];
    }

    private getDefaultMember() {
        return this.userService.getCurrentUser()
            .pipe(
                this.untilThis,
                map(resp => {
                    this.defaultMember = { priority: 1, memberId: resp?.id, name: resp.userName };
                    this.refreshMembers();
                }),
            );
    }

    private getCurrentTeamId() {
        return this.teamService.currentTeamEmitted$
            .pipe(
                this.untilThis,
                filter(t => !!t),
                map((teamId) => {
                    this.teamId = teamId!;
                }),
            );
    }
}
