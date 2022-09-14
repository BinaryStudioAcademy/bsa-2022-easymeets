import { Role } from '@shared/enums/role';
import { Status } from '@shared/enums/status';

export interface ITeamMember {
    id: bigint;
    image?: string;
    name: string;
    email: string;
    pageLink: string;
    role: Role;
    status: Status;
    connectedCalendars?: string[];
    userId?: bigint;
}
