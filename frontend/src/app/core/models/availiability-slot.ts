import { Team } from './team';
import { User } from './user';

export interface AvailabilitySlot {
    user: User;
    team: Team;
    size: number;
    link: string;
    isEnabled: boolean
    isVisible: boolean
    location: Location
}
