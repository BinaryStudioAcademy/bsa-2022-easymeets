import { Component } from '@angular/core';

@Component({
    selector: 'app-team',
    templateUrl: './team.component.html',
    styleUrls: ['./team.component.sass'],
})
export class TeamComponent {
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
}
