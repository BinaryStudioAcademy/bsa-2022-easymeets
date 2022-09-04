import { Component, EventEmitter, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { CountryLabelMapping } from '@core/helpers/country-label-mapping';
import { CountryCode } from '@core/helpers/countryCode';
import { DateFormatLabelMapping } from '@core/helpers/date-format-label-mapping';
import { LanguageLabelMapping } from '@core/helpers/language-label-mapping';
import { TimeFormatLabelMapping } from '@core/helpers/time-format-label-mapping';
import { IImagePath } from '@core/models/IImagePath';
import { IUpdateUser } from '@core/models/IUpdateUser';
import { IUser } from '@core/models/IUser';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { UserService } from '@core/services/user.service';
import { Country } from '@shared/enums/country';
import { DateFormat } from '@shared/enums/dateFormat';
import { Language } from '@shared/enums/language';
import { TimeFormat } from '@shared/enums/timeFormat';

@Component({
    selector: 'app-user-profile-page',
    templateUrl: './user-profile-page.component.html',
    styleUrls: ['./user-profile-page.component.sass'],
})
export class UserProfilePageComponent extends BaseComponent implements OnInit {
    constructor(
        private userService: UserService,
        public notificationService: NotificationService,
        private confirmationWindowService: ConfirmationWindowService,
    ) {
        super();
    }

    public imageUrl?: string;

    public user: IUser;

    public userForm: FormGroup;

    public timeFormatValues = [TimeFormat.TwentyFourHour, TimeFormat.TwelveHour];

    public timeFormatLabelMapping = TimeFormatLabelMapping;

    public dateFormatValues = [DateFormat.MonthDayYear, DateFormat.DayMonthYear];

    public dateFormatLabelMapping = DateFormatLabelMapping;

    public languageValues = [Language.Eng, Language.Ukr, Language.Pl, Language.Fr, Language.It];

    public languageLabelMapping = LanguageLabelMapping;

    public countryValues = Object.values(Country);

    public countryLabelMapping = CountryLabelMapping;

    public countryCodeValues = CountryCode;

    public countryCode: string;

    public isTimeZoneExist: boolean = true;

    public userNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(/^[єЄіІїЇa-zA-Z\dа-яА-Я-]+(\s|)[єЄіІїЇa-zA-Z\dа-яА-Я-]*$/),
    ]);

    public phoneControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(9),
        Validators.maxLength(11),
    ]);

    public ngOnInit(): void {
        this.userForm = new FormGroup({
            userName: this.userNameControl,
            phone: this.phoneControl,
            country: new FormControl(),
            dateFormat: new FormControl(),
            timeFormat: new FormControl(),
            language: new FormControl(),
            timeZone: new FormControl(),
            image: new FormControl(),
        });

        this.userService
            .getCurrentUser()
            .pipe(this.untilThis)
            .subscribe((user) => {
                this.user = user;
                this.userForm.patchValue({
                    userName: user.userName,
                    phone: user.phone,
                    country: user.country,
                    dateFormat: user.dateFormat,
                    timeFormat: user.timeFormat,
                    language: user.language,
                    timeZone: user.timeZone,
                    image: user.image,
                });
                this.imageUrl = user.image;
                this.isTimeZoneExist = !this.user?.timeZone;
                if (user.phoneCode) {
                    this.countryCode = user.phoneCode;
                } else {
                    this.changeCountryCode(this.userForm);
                }
            });
    }

    public OnSubmit(form: FormGroup) {
        const editedUser: IUpdateUser = {
            id: this.user.id,
            phoneCode: this.countryCodeValues[form.value.country as Country],
            phone: form.value.phone,
            userName: form.value.userName,
            country: form.value.country,
            dateFormat: form.value.dateFormat,
            language: form.value.language,
            timeFormat: form.value.timeFormat,
            timeZone: form.value.timeZone,
        };

        this.userService
            .editUser(editedUser)
            .pipe(this.untilThis)
            .subscribe({
                next: () =>
                    this.notificationService.showSuccessMessage('Personal information was updated successfully.'),
            });
    }

    public changeCountryCode(form: FormGroup) {
        this.countryCode = this.countryCodeValues[form.value.country as Country];
    }

    public loadImage(event: Event) {
        const target = event.target as HTMLInputElement;
        const fileToUpload: File = (target.files as FileList)[0];

        if (fileToUpload.size / 1000000 > 5) {
            this.confirmCancelDialog();

            return;
        }
        const formData = new FormData();

        formData.append('file', fileToUpload, fileToUpload.name);

        this.userService
            .uploadImage(formData)
            .pipe(this.untilThis)
            .subscribe({
                next: (resp: IImagePath) => {
                    this.imageUrl = resp.path;
                },
            });
    }

    public confirmCancelDialog(): void {
        this.confirmationWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Ok',
                    onClickEvent: new EventEmitter<void>(),
                },
            ],
            title: 'Oops...',
            message: "Image can't be heavier than 5MB!",
        });
    }
}
