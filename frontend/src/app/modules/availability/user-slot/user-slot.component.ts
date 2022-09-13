import { Clipboard } from '@angular/cdk/clipboard';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IUser } from '@core/models/IUser';
import { NotificationService } from '@core/services/notification.service';
import { environment } from '@env/environment';

@Component({
    selector: 'app-user-slot',
    templateUrl: './user-slot.component.html',
    styleUrls: ['./user-slot.component.sass'],
})
export class UserSlotComponent extends BaseComponent {
    @Input() public userSlots: Array<IAvailabilitySlot>;

    @Input() public currentUser: IUser;

    @Input() public showArrow: boolean;

    @Output() isReload = new EventEmitter<boolean>();

    constructor(
        private router: Router,
        private clipboard: Clipboard,
        private notificationService: NotificationService,
    ) {
        super();
    }

    goToPage(pageName: string) {
        this.router.navigate([`${pageName}`]);
    }

    isDeleted(isRemove: boolean) {
        this.isReload.emit(isRemove);
    }

    isChangedActivity(isChanged: boolean) {
        this.isReload.emit(isChanged);
    }

    public getDefinitionLink() {
        return `${environment.appUrl}/external-booking/choose-meeting/${this.currentUser.personalUrl}`;
    }

    saveLink() {
        this.clipboard.copy(this.getDefinitionLink());
        this.notificationService.showSuccessMessage('Link copied to clipboard');
    }
}
