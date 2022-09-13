import { Component, EventEmitter, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { getDefaultTimeZone } from '@core/helpers/time-zone-helper';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-booking-window',
    templateUrl: './booking-window.component.html',
    styleUrls: ['./booking-window.component.sass'],
})
export class BookingWindowComponent extends BaseComponent {
    maxVisibleMembers: number = 10;

    locationTypeMapping = LocationTypeMapping;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<BookingWindowComponent>,
    ) {
        super();
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
        this.dialogRef.close();
    }

    getTimeZoneValue() {
        return getDefaultTimeZone().timeValue;
    }
}
