import { Role } from '@shared/enums/role';
import { Status } from '@shared/enums/status';

export interface ITeamMember {
    image?: string;
    name?: string;
    email?: string;
    pageLink?: string;
    role?: Role;
    status?: Status;
    calendar?: string;
}
