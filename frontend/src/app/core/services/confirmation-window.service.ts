import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BookingWindowComponent } from '@shared/components/booking-window/booking-window.component';
import { ConfirmationWindowComponent } from '@shared/components/confirmation-window/confirmation-window.component';
import { OwnerRightsWindowComponent } from '@shared/components/owner-rights-window/owner-rights-window.component';
import { TeamMembersWindowComponent } from '@shared/components/team-members-window/team-members-window.component';
import { UnsavedChangesComponent } from '@shared/components/unsaved-changes/unsaved-changes.component';
import { confirmLeaveTitle, leavePageMessage } from '@shared/constants/shared-messages';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';
import { ITeamMembersDialogData } from '@shared/models/ITeamMembersDialogData';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class ConfirmationWindowService {
    // eslint-disable-next-line no-empty-function
    constructor(private dialog: MatDialog) {}

    openConfirmDialog(data: IConfirmDialogData) {
        return this.dialog
            .open(ConfirmationWindowComponent, {
                data,
            })
            .afterClosed();
    }

    openBookingDialog(data: IConfirmDialogData) {
        return this.dialog
            .open(BookingWindowComponent, {
                data,
            })
            .afterClosed();
    }

    confirmLeaveDialog(): Observable<boolean> {
        return this.dialog
            .open(UnsavedChangesComponent, {
                data: {
                    title: confirmLeaveTitle,
                    message: leavePageMessage,
                },
            })
            .afterClosed();
    }

    openTeamMembersDialog(data: ITeamMembersDialogData) {
        return this.dialog
            .open(TeamMembersWindowComponent, {
                data,
            })
            .afterClosed();
    }

    openOwnerRightsDialog(data: ITeamMembersDialogData) {
        return this.dialog
            .open(OwnerRightsWindowComponent, {
                data,
            })
            .afterClosed();
    }
}
