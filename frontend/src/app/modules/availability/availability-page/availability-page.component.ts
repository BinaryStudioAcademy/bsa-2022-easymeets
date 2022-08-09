import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent implements OnInit {
    // eslint-disable-next-line @angular-eslint/no-empty-lifecycle-method
    ngOnInit(): void {}

    slots: Array<{ time: string; user: string; link: string; meetingPlace: string }> = [
        { time: '30 min', user: 'Heorhii Matviichuk', link: 'Link.com/heorhii', meetingPlace: 'Meet' },
        { time: '1 hour', user: 'Heorhii Matviichuk', link: 'Link.com/heorhii', meetingPlace: 'Zoom' },
        { time: '15 min', user: 'Me & 1 Booker', link: 'Link.com/heorhii', meetingPlace: 'Zoom' },
        { time: '30 min', user: 'Heorhii Matviichuk', link: 'Link.com/heorhii', meetingPlace: 'Meet' },
    ];
}
