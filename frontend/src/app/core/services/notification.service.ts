import { inject, Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({ providedIn: 'root' })
export class NotificationService {
    public constructor(private snackBar: MatSnackBar) {
        this.snackBar = inject(MatSnackBar);
    }

    public showErrorMessage(error: string) {
        this.snackBar.open(error, '', { duration: 2500, panelClass: 'error-snack-bar' });
    }

    public showInfoMessage(message: string) {
        this.snackBar.open(message, '', { duration: 2500, panelClass: 'info-snack-bar' });
    }

    public showWarningMessage(message: string) {
        this.snackBar.open(message, '', { duration: 2500, panelClass: 'warning-snack-bar' });
    }

    public showSuccessMessage(message: string) {
        this.snackBar.open(message, '', { duration: 2500, panelClass: 'success-snack-bar' });
    }
}
