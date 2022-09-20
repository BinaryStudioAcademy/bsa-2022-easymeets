import { SlotParticipationOption } from '@shared/enums/slotParticipationOption';
import { SlotScheduleMode } from '@shared/enums/slotScheduleMode';

export const getScheduleModes = () => [SlotScheduleMode.ForEach, SlotScheduleMode.OneForAll];

export const getParticipationOptions = () => [SlotParticipationOption.One, SlotParticipationOption.All];
