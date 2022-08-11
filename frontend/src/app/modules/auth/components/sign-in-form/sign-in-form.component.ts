import { Component } from '@angular/core';
import { FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Component({
    selector: 'app-sign-in-form',
    templateUrl: './sign-in-form.component.html',
    styleUrls: ['./sign-in-form.component.sass', '../../shared-styles.sass'],
})
export class SignInFormComponent {
    public hidePassword = true;

    public signInForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        password: new FormControl('', [Validators.required, Validators.minLength(6)]),
    });

    constructor(private authService: AuthService, private router: Router) {}

    public onSignIn(): void {
        this.authService.signIn(this.signInForm.value.email!, this.signInForm.value.password!)
            .then(() => this.router.navigateByUrl('main'));
    }

    public onSignInWithGoogle(): void {
        this.authService.loginWithGoogle()
            .then(() => this.router.navigateByUrl('main'));
    }

    public checkErrors(control: string): string | undefined {
        const { errors } = (this.signInForm.controls as any)[control];

        return this.getErrorMessage(errors);
    }

    private getErrorMessage(errors: ValidationErrors): string | undefined {
        if (errors['required']) {
            return 'Password is required!';
        } if (errors['minlength']) {
            return 'Password should be longer than 6 characters!';
        }

        return;
    }
}
