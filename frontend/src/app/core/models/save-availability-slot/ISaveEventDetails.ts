export interface ISaveEventDetails {
    link: string;
    welcomeMessage: string;
    language: string;
    bookingsPerDay: number;
    allowToAddGuests: boolean;
    passwordProtectionIsUsed: boolean;
    passwordProtection?: string;
    timeZoneVisibility: boolean;
}
