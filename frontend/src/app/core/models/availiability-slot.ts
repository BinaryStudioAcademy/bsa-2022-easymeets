import { Location } from './location';
import { User } from './user';

export interface AvailabilitySlot {
    name: string;
    user: User;
    size: number;
    link: string;
    isEnabled: boolean
    isVisible: boolean
    location: Location
    members: Array<User>
}
