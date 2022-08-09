import { Component, ElementRef } from '@angular/core';

@Component({
    // eslint-disable-next-line @angular-eslint/no-host-metadata-property
    host: {
        '(document:click)': 'onClick($event)',
    },
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent {
    // eslint-disable-next-line no-empty-function
    constructor(private _eref: ElementRef) {}

    onSelectDropdown(id: number, outsideCall: boolean = false): void {
        const dropdownDetailsDiv: HTMLElement = document.getElementById(`dropdown-content-${id}`) as HTMLElement;

        if (outsideCall) {
            dropdownDetailsDiv.style.display = dropdownDetailsDiv.style.display === 'block' ? 'none' : 'none';
        } else {
            dropdownDetailsDiv.style.display = dropdownDetailsDiv.style.display === 'block' ? 'none' : 'block';
        }
    }

    onClick(event: Event) {
        if (!this._eref.nativeElement.contains(event.target)) {
            this.onSelectDropdown(1, true);
            this.onSelectDropdown(2, true);
        }
    }
}
