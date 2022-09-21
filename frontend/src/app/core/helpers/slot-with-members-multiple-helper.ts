import { Color } from '@core/enums/color.enum';
import { SlotType } from '@core/enums/slot-type.enum';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { LocationType } from '@shared/enums/locationType';
import { SlotParticipationOption } from '@shared/enums/slotParticipationOption';

import { getLocalMandatoryQuestions } from './questions-mandatory-helper';
import { getScheduleItems } from './schedule-list-helper';
import { getDefaultTimeZone } from './time-zone-helper';

export const getTeamForMultipleChoice = (): IAvailabilitySlot[] => [
    {
        id: 1n,
        name: 'name',
        authorName: 'authorName',
        type: SlotType.Personal,
        size: 5,
        link: '',
        isEnabled: true,
        isVisible: true,
        color: Color.Cyan,
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
            exclusionDates: [],
            withTeamMembers: true,
            definedExternally: false,
        },
        slotMembers: [],
        welcomeMessage: 'welcomeMessage',
        language: 'language',
        bookingsPerDay: 5,
        passwordProtectionIsUsed: true,
        timeZoneVisibility: true,
        participationRule: SlotParticipationOption.All,
    },
];
