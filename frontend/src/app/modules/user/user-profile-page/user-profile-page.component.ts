import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { UserService } from '@core/services/user.service';
import { Country } from '@shared/enums/country';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';
import { TimeZone } from '@shared/enums/timeZone';
import { User } from '@shared/models/user/user';

@Component({
    selector: 'app-user-profile-page',
    templateUrl: './user-profile-page.component.html',
    styleUrls: ['./user-profile-page.component.sass'],
})
export class UserProfilePageComponent implements OnInit {
    public user: User;

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

    OnSubmit(form: any) {
        this.user.userName = form.value.userName;
        console.log(form.value);
    }

    constructor(private userService: UserService) {
    }

    ngOnInit(): void {
        this.userForm = new FormGroup({
            userName: new FormControl(),
            phone: new FormControl(),
            country: new FormControl(),
            dateFormat: new FormControl(),
            timeFormat: new FormControl(),
            language: new FormControl(),
            timeZone: new FormControl(),
        });

        this.userService.getUser(1).subscribe((user) => {
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
