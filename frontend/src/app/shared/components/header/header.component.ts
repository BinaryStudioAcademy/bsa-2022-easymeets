/* eslint-disable indent */
import { Component, ElementRef } from '@angular/core';

// eslint-disable-next-line no-shadow
export enum DropDownTypes {
    TeamsDD,
    AccountDD,
}

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

    public DropDownTypesEnum = DropDownTypes;

    onSelectDropdown(type: DropDownTypes, outsideCall: boolean = false): void {
        let dropdownId: string = '';

        switch (type) {
            case DropDownTypes.AccountDD: {
                dropdownId += 'account';
                break;
            }
            case DropDownTypes.TeamsDD: {
                dropdownId += 'teams';
                break;
            }
            default: {
                break;
            }
        }

        const dropdownDetailsDiv: HTMLElement = document.getElementById(
            `dropdown-content-${dropdownId}`,
        ) as HTMLElement;

        if (outsideCall) {
            dropdownDetailsDiv.style.display = dropdownDetailsDiv.style.display === 'block' ? 'none' : 'none';
        } else {
            dropdownDetailsDiv.style.display = dropdownDetailsDiv.style.display === 'block' ? 'none' : 'block';
        }
    }

    onClick(event: Event) {
        if (!this._eref.nativeElement.contains(event.target)) {
            this.onSelectDropdown(DropDownTypes.AccountDD, true);
            this.onSelectDropdown(DropDownTypes.TeamsDD, true);
        }
    }
}
