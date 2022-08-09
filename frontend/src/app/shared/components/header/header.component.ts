import { Component } from '@angular/core';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent {
    onSelectDropdown(id: number): void {
        const dropdownDetailsDiv: HTMLElement = document.getElementById(`dropdown-content-${id}`) as HTMLElement;

        dropdownDetailsDiv.style.display = dropdownDetailsDiv.style.display === 'block' ? 'none' : 'block';
    }
}
