import { Slot } from '@core/interfaces/slot-interface';

export const getDefaultSlots = (): Array<Slot> => [
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

// export class Hello {
//     hello: string;
// }
