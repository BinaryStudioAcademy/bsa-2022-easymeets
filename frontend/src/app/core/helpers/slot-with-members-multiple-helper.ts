import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { LocationType } from '@shared/enums/locationType';

import { getLocalMandatoryQuestions } from './questions-mandatory-helper';
import { getScheduleItems } from './schedule-list-helper';

export const getTeamForMultipleChoice = (): IAvailabilitySlot[] => [
    {
        id: 1n,
        name: 'name',
        authorName: 'authorName',
        size: 5,
        link: '',
        isEnabled: true,
        isVisible: true,
        locationType: LocationType.GoogleMeet,
        members: [
            {
                id: 1n,
                name: 'First Member',
                memberImage: '',
            },
            {
                id: 2n,
                name: 'Second Member',
                memberImage: '',
            },
            {
                id: 3n,
                name: 'Third Member',
                memberImage: '',
            },
            {
                id: 4n,
                name: 'Fourth Member',
                memberImage: '',
            },
        ],
        questions: getLocalMandatoryQuestions(),
        schedule: {
            timeZone: 1,
            scheduleItems: getScheduleItems(),
            withTeamMembers: true,
            definedExternally: false,
        },
        welcomeMessage: 'welcomeMessage',
        frequency: 5,
        language: 'language',
        bookingsPerDay: 5,
        passwordProtectionIsUsed: true,
        timeZoneVisibility: true,
    },
];
