import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { ITeamMember } from '@core/models/ITeamMember';
import { ISlotMember } from '@core/models/save-availability-slot/ISlotMember';
import { TeamService } from '@core/services/team.service';
import { ConfirmationWindowComponent } from '@shared/components/confirmation-window/confirmation-window.component';
import { ISlotMemberDialogData } from '@shared/models/ISlotMemberDialogData';

@Component({
    selector: 'app-slot-members-window',
    templateUrl: './slot-members-window.component.html',
    styleUrls: ['./slot-members-window.component.sass'],
})
export class SlotMembersWindowComponent extends BaseComponent implements OnInit {
    public filterValue = '';

    public selectedMembers: ISlotMember[] = [];

    public alreadySelected: ISlotMember[] = [];

    public teamId: number;

    public filteredMembers: ISlotMember[] = [];

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: ISlotMemberDialogData,
        private dialogRef: MatDialogRef<ConfirmationWindowComponent>,
        private teamService: TeamService,
    ) {
        super();
        this.alreadySelected = data.alreadySelected;
        this.teamId = data.teamId;
    }

    public onAddClick() {
        this.data.onAddEvent.emit(this.selectedMembers);
        this.dialogRef.close();
    }

    public onCancelClick() {
        this.dialogRef.close();
    }

    public changeSelection(member: ISlotMember) {
        if (this.selectedMembers.some(m => m.memberId === member.memberId)) {
            this.selectedMembers = this.selectedMembers.filter(m => m.memberId !== member.memberId);
        } else {
            this.selectedMembers = [...this.selectedMembers, member];
        }
    }

    public getFilteredMembers() {
        return this.filteredMembers.filter(m => this.passesFilter(m.name ?? '') || this.passesFilter(m.email ?? ''));
    }

    public passesFilter(value: string) {
        return value.toLowerCase().includes(this.filterValue.toLowerCase());
    }

    public deselect() {
        this.selectedMembers = [];
    }

    public isSelected(member: ISlotMember) {
        return this.selectedMembers.some(m => m.memberId === member.memberId);
    }

    public ngOnInit(): void {
        this.teamService.getTeamMembers(this.teamId)
            .pipe(this.untilThis)
            .subscribe(members => {
                this.filteredMembers = this.getNotAdded(members);
            });
    }

    private getNotAdded(members: ITeamMember[]) {
        return members
            .map(member => ({
                priority: 1,
                memberId: member.userId,
                name: member.name,
                email: member.email,
                image: member.image,
            }))
            .filter(member => !this.alreadySelected.some(m => m.memberId === member.memberId));
    }
}
