import { Component, EventEmitter, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BaseComponent } from '@core/base/base.component';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { IConfirmButtonOptions } from '@shared/models/confirmWindow/IConfirmButtonOptions';
import { IConfirmDialogData } from '@shared/models/confirmWindow/IConfirmDialogData';

@Component({
    selector: 'app-confirmation-window',
    templateUrl: './confirmation-window.component.html',
    styleUrls: ['./confirmation-window.component.sass'],
})
export class ConfirmationWindowComponent extends BaseComponent implements OnInit {
    title: string;

    message?: string;

    buttonsOptions?: IConfirmButtonOptions[];

    locationTypeMapping = LocationTypeMapping;

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: IConfirmDialogData,
        private dialogRef: MatDialogRef<ConfirmationWindowComponent>,
    ) {
        super();
        this.title = data.title;
        this.message = data.message;
        this.buttonsOptions = data.buttonsOptions;
    }

    ngOnInit(): void {
        this.dialogRef
            .keydownEvents()
            .pipe(this.untilThis)
            .subscribe((event) => {
                if (event.key === 'Escape') {
                    this.dialogRef.close();
                }
            });
    }

    onClick(event: EventEmitter<void>) {
        event?.next();
        this.dialogRef.close();
    }
}
