import { Slot } from '@core/interfaces/slot-interface';

export const getDefaultSlots = (): Array<Slot> => [
    {
        id: 1,
        time: '30 min',
        user: 'Heorhii Matviichuk',
        link: 'Link.com/heorhii',
        meetingPlace: 'Meet',
        avatars: ['assets/bulochka.PNG', 'assets/bulochka.PNG'],
    },
    {
        id: 2,
        time: '1 hour',
        user: 'Heorhii Matviichuk',
        link: 'Link.com/heorhii',
        meetingPlace: 'Zoom',
        avatars: ['assets/bulochka.PNG'],
    },
    {
        id: 3,
        time: '15 min',
        user: 'Me & 1 Booker',
        link: 'Link.com/heorhii',
        meetingPlace: 'Zoom',
        avatars: ['assets/bulochka.PNG', 'assets/bulochka.PNG', 'assets/bulochka.PNG'],
    },
];
