import { Role } from '@shared/enums/role';
import { Status } from '@shared/enums/status';

import { IUserCalendar } from './calendar/IUserCalendar';

export interface ITeamMember {
    image?: string;
    name: string;
    email: string;
    pageLink: string;
    role: Role;
    status: Status;
    calendar?: IUserCalendar;
}
