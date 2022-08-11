import { Slot } from '@core/interfaces/slot-interface';
import { TeamWithSlot } from '@core/models/team-with-slot';

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

export const getDefaultTeams = (): Array<TeamWithSlot> => [
    {
        name: 'Heorhii Matviichuk',
        pageLink: 'link://dsasdasfs',
        availabilitySlots: [{
            name: 'name',
            size: 30,
            user: { name: 'Heorhii Matviichuk' },
            link: 'Link.com/heorhii',
            location: { name: 'Meet' },
            members: [{ name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' }],
            isEnabled: true,
            isVisible: false,
        }, {
            name: 'name',
            size: 45,
            user: { name: 'Heorhii Matviichuk' },
            link: 'Link.com/heorhii',
            location: { name: 'Zoom' },
            members: [{ name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' }],
            isEnabled: true,
            isVisible: true,
        }, {
            name: 'name',
            size: 15,
            user: { name: 'Me & 1 Booker' },
            link: 'Link.com/heorhii',
            location: { name: 'Meet' },
            members: [{ name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' },
                { name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' },
                { name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' }],
            isEnabled: false,
            isVisible: true,
        }],
    },
    { name: 'Binary Studio',
        pageLink: 'link://dsasdasfs',
        availabilitySlots: [{
            name: 'name',
            size: 30,
            user: { name: 'Heorhii Matviichuk' },
            link: 'Link.com/heorhii',
            location: { name: 'Meet' },
            members: [{ name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' },
                { name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' }],
            isEnabled: true,
            isVisible: false,
        }, {
            name: 'name',
            size: 45,
            user: { name: 'Heorhii Matviichuk' },
            link: 'Link.com/heorhii',
            location: { name: 'Zoom' },
            members: [{ name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' }],
            isEnabled: true,
            isVisible: true,
        }, {
            name: 'name',
            size: 15,
            user: { name: 'Me & 1 Booker' },
            link: 'Link.com/heorhii',
            location: { name: 'Meet' },
            members: [{ name: 'Heorhii Matviichuk', imagePath: 'assets/bulochka.PNG' }],
            isEnabled: false,
            isVisible: true,
        }],
    }];
