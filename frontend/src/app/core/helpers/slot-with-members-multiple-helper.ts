import { Color } from '@core/enums/color.enum';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { LocationType } from '@shared/enums/locationType';

import { getLocalMandatoryQuestions } from './questions-mandatory-helper';
import { getScheduleItems } from './schedule-list-helper';
import { getDefaultTimeZone } from './time-zone-helper';

export const getTeamForMultipleChoice = (): IAvailabilitySlot[] => [
    {
        id: 1n,
        name: 'name',
        authorName: 'authorName',
        size: 5,
        link: '',
        isEnabled: true,
        isVisible: true,
        color: Color.Azure,
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
            timeZone: getDefaultTimeZone(),
            scheduleItems: getScheduleItems(),
            withTeamMembers: true,
            definedExternally: false,
        },
        welcomeMessage: 'welcomeMessage',
        language: 'language',
        bookingsPerDay: 5,
        passwordProtectionIsUsed: true,
        timeZoneVisibility: true,
    },
];
