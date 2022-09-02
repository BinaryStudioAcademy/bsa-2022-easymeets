export interface ISaveEventDetails {
    link: string;
    welcomeMessage: string;
    language: string;
    bookingsPerDay: number;
    passwordProtectionIsUsed: boolean;
    passwordProtection?: string;
    timeZoneVisibility: boolean;
}
