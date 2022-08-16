import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { IUser } from '@core/models/IUser';
import { NotificationService } from '@core/services/notification.service';
import { UserService } from '@core/services/user.service';
import { Country } from '@shared/enums/country';
import { CountryCode } from '@shared/enums/countryCode';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';
import { TimeZone } from '@shared/enums/timeZone';

@Component({
    selector: 'app-user-profile-page',
    templateUrl: './user-profile-page.component.html',
    styleUrls: ['./user-profile-page.component.sass'],
})
export class UserProfilePageComponent implements OnInit {
    public user: IUser;

    public userForm: FormGroup;

    public timeFormatKeys = Object.keys(TimeFormat);

    public timeFormatValues = Object.values(TimeFormat);

    public dateFormatKeys = Object.keys(DateFormat);

    public dateFormatValues = Object.values(DateFormat);

    public languageKeys = Object.keys(Language);

    public languageValues = Object.values(Language);

    public timeZoneKeys = Object.keys(TimeZone);

    public timeZoneValues = Object.values(TimeZone);

    public countryKeys = Object.keys(Country);

    public countryValues = Object.values(Country);

    public countryCodeValues = Object.values(CountryCode);

    public countryCode: string;

    public userNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(/^[іІїЇa-zA-Z\dа-яА-Я- ]*$/),
    ]);

    public phoneControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(10),
    ]);

    // eslint-disable-next-line no-empty-function
    constructor(private userService: UserService, public notificationService: NotificationService) {
    }

    public ngOnInit(): void {
        this.userForm = new FormGroup({
            userName: this.userNameControl,
            phone: this.phoneControl,
            country: new FormControl(),
            dateFormat: new FormControl(),
            timeFormat: new FormControl(),
            language: new FormControl(),
            timeZone: new FormControl(),
        });

        this.userService.getCurrentUserById(1).subscribe((user) => {
            this.user = user;
            this.userForm.patchValue({
                userName: user.userName,
                phone: user.phone?.substr(user.phone.length - 10),
                country: user.country,
                dateFormat: user.dateFormat,
                timeFormat: user.timeFormat,
                language: user.language,
                timeZone: user.timeZone,
            });
            this.changeCountryCode(this.userForm);
        });
    }

    public OnSubmit(form: FormGroup) {
        const editedUser: IUser = {
            id: this.user.id,
            email: this.user.email,
            image: this.user.image,
            phone: `+${this.countryCodeValues[form.value.country]}${form.value.phone}`,
            userName: form.value.userName,
            country: form.value.country,
            dateFormat: form.value.dateFormat,
            language: form.value.language,
            timeFormat: form.value.timeFormat,
            timeZone: form.value.timeZone,
        };

        this.userService.editUser(editedUser).subscribe(
            () => {
                this.notificationService.showSuccessMessage('Personal information was updated successfully.');
            },
            () => {
                this.notificationService.showErrorMessage('There was an error while updating.');
            },
        );
    }

    public changeCountryCode(form: FormGroup) {
        this.countryCode = this.countryCodeValues[form.value.country];
    }
}
