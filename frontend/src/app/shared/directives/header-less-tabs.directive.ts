import { Directive, ElementRef, OnInit } from '@angular/core';

@Directive({
    // eslint-disable-next-line @angular-eslint/directive-selector
    selector: '[header-less-tabs]',
})
export class HeaderLessTabsDirective implements OnInit {
    // eslint-disable-next-line no-empty-function
    constructor(private eleRef: ElementRef) {}

    ngOnInit(): void {
        this.eleRef.nativeElement.children[0].style.display = 'none';
    }
}
