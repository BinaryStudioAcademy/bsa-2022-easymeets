import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-availability-page',
    templateUrl: './availability-page.component.html',
    styleUrls: ['./availability-page.component.sass'],
})
export class AvailabilityPageComponent implements OnInit {
    public slots: Array<{ time: string; user: string; link: string; meetingPlace: string; avatars: Array<string> }> = [
        {
            time: '30 min',
            user: 'Heorhii Matviichuk',
            link: 'Link.com/heorhii',
            meetingPlace: 'Meet',
            avatars: ['assets/bulochka.PNG', 'assets/bulochka.PNG'],
        },
        {
            time: '1 hour',
            user: 'Heorhii Matviichuk',
            link: 'Link.com/heorhii',
            meetingPlace: 'Zoom',
            avatars: ['assets/bulochka.PNG'],
        },
        {
            time: '15 min',
            user: 'Me & 1 Booker',
            link: 'Link.com/heorhii',
            meetingPlace: 'Zoom',
            avatars: ['assets/bulochka.PNG', 'assets/bulochka.PNG', 'assets/bulochka.PNG'],
        },
    ];

    // eslint-disable-next-line @angular-eslint/no-empty-lifecycle-method
    ngOnInit(): void {}
}
