import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { IUser } from '@core/models/IUser';
import { UserService } from '@core/services/user.service';
import { Country } from '@shared/enums/country';
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

    timeFormatKeys = Object.keys(TimeFormat);

    timeFormatValues = Object.values(TimeFormat);

    dateFormatKeys = Object.keys(DateFormat);

    dateFormatValues = Object.values(DateFormat);

    languageKeys = Object.keys(Language);

    languageValues = Object.values(Language);

    timeZoneKeys = Object.keys(TimeZone);

    timeZoneValues = Object.values(TimeZone);

    countryKeys = Object.keys(Country);

    countryValues = Object.values(Country);

    constructor(private userService: UserService) {
    }

    OnSubmit(form: FormGroup) {
        const editedUser: IUser = {
            id: this.user.id,
            email: this.user.email,
            image: this.user.image,
            phone: form.value.phone,
            userName: form.value.userName,
            country: form.value.country,
            dateFormat: form.value.dateFormat,
            language: form.value.language,
            timeFormat: form.value.timeFormat,
            timeZone: form.value.timeZone,
        };

        this.userService.editUser(editedUser).subscribe(
            () => {},
        );
    }

    ngOnInit(): void {
        this.userForm = new FormGroup({
            userName: new FormControl('', [
                Validators.required,
                Validators.minLength(2),
                Validators.maxLength(50),
                Validators.pattern(/^[a-zA-Z\dа-яА-Я- ]*$/),
            ]),
            phone: new FormControl(),
            country: new FormControl(),
            dateFormat: new FormControl(),
            timeFormat: new FormControl(),
            language: new FormControl(),
            timeZone: new FormControl(),
        });

        this.userService.getCurrentUserById(1).subscribe((user) => {
            this.user = user;
            // this.editedUser = { ...this.user };
            this.userForm.patchValue({
                userName: user.userName,
                phone: user.phone,
                country: user.country,
                dateFormat: user.dateFormat,
                timeFormat: user.timeFormat,
                language: user.language,
                timeZone: user.timeZone,
            });
        });
    }
}
