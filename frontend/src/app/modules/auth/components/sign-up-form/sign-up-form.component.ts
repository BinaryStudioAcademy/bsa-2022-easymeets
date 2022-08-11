import { Component } from '@angular/core';
import { FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { CustomValidators } from '@modules/auth/validators/custom-validators';

@Component({
    selector: 'app-sign-up-form',
    templateUrl: './sign-up-form.component.html',
    styleUrls: ['./sign-up-form.component.sass', '../../shared-styles.sass'],
})
export class SignUpFormComponent {
    public hidePassword = true;

    public signUpForm = new FormGroup(
        {
            email: new FormControl('', [Validators.required, Validators.email]),
            name: new FormControl('', [Validators.required]),
            password: new FormControl('', [Validators.required, Validators.minLength(6)]),
            confirmPassword: new FormControl('', [Validators.required]),
        },
        {
            validators: CustomValidators.passwordsMatching,
            updateOn: 'blur', // 'change' | 'blur' | 'submit'
        },
    );

    constructor(private authService: AuthService, private router: Router) {}

    public onSignUp(): void {
        this.authService
            .signUp(this.signUpForm.value.email!, this.signUpForm.value.password!)
            .then(() => this.router.navigateByUrl('main'));
    }

    public onSignInWithGoogle(): void {
        this.authService.loginWithGoogle().then(() => this.router.navigateByUrl('main'));
    }

    public checkErrors(control: string): string | undefined {
        const { errors } = (this.signUpForm.controls as any)[control];

        return this.getErrorMessage(errors);
    }

    private getErrorMessage(errors: ValidationErrors): string | undefined {
        if (errors['required']) {
            return 'Password is required!';
        }
        if (errors['minlength']) {
            return 'Password should be longer than 6 characters!';
        }

        return;
    }
}
