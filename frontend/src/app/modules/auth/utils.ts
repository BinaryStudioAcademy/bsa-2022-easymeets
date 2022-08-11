export class Utils {
    public static passwordsMatch(password: string, confirmPassword: string): boolean {
        return password === confirmPassword && confirmPassword !== undefined;
    }
}
