import { Component, EventEmitter, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { CountryLabelMapping } from '@core/helpers/country-label-mapping';
import { CountryCode } from '@core/helpers/countryCode';
import { DateFormatLabelMapping } from '@core/helpers/date-format-label-mapping';
import { LanguageLabelMapping } from '@core/helpers/language-label-mapping';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { TimeFormatLabelMapping } from '@core/helpers/time-format-label-mapping';
import { IImagePath } from '@core/models/IImagePath';
import { IUpdateUser } from '@core/models/IUpdateUser';
import { IUser } from '@core/models/IUser';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { SettingPageService } from '@core/services/setting-page.service';
import { UserService } from '@core/services/user.service';
import { userNameRegex } from '@shared/constants/model-validation';
import { invalidCharactersMessage } from '@shared/constants/shared-messages';
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
        private settingPageService: SettingPageService,
    ) {
        super();
    }

    public imageUrl?: string;

    public user?: IUser;

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

    public invalidCharactersMessage = invalidCharactersMessage;

    public userNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(userNameRegex),
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
                    image: user.image,
                });
                this.userForm.markAsPristine();
                this.imageUrl = user.image;
                if (user.phoneCode) {
                    this.countryCode = user.phoneCode;
                } else {
                    this.changeCountryCode(this.userForm);
                }
            });

        this.settingPageService.updateButtonClickEvent$.pipe(this.untilThis).subscribe(() => {
            this.OnSubmit();
        });

        this.userForm.statusChanges.pipe(this.untilThis).subscribe(() => {
            this.settingPageService.updateButtonActive(!this.userForm.invalid && !this.userForm.pending && this.userForm.dirty);
        });
    }

    public OnSubmit() {
        if (this.user) {
            this.userForm.markAsPristine();
            const editedUser: IUpdateUser = {
                id: this.user.id,
                phoneCode: this.countryCodeValues[this.userForm.value.country as Country],
                phone: this.userForm.value.phone,
                userName: this.userForm.value.userName,
                country: this.userForm.value.country,
                dateFormat: this.userForm.value.dateFormat,
                language: this.userForm.value.language,
                timeFormat: this.userForm.value.timeFormat,
            };

            this.userService
                .editUser(editedUser)
                .pipe(this.untilThis)
                .subscribe({
                    next: () =>
                        this.notificationService.showSuccessMessage('Personal information was updated successfully.'),
                    error: () =>
                        this.userForm.markAsDirty()
                    ,
                });
        }
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
            .uploadImage(this.user, formData)
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

    public userNameChanged(value: string) {
        this.userForm.patchValue({ userName: removeExcessiveSpaces(value) });
    }
}
