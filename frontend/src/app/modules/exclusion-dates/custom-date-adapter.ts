import { NativeDateAdapter } from '@angular/material/core';

export class CustomDateAdapter extends NativeDateAdapter {
    // eslint-disable-next-line no-unused-vars
    override getDayOfWeekNames(_: 'long' | 'short' | 'narrow') {
        return ['SUN', 'MON', 'TUE', 'WED', 'THU', 'FRI', 'SAT'];
    }
}
