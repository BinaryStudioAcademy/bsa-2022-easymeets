import { Component, EventEmitter, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { IUser } from '@core/models/IUser';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { UploadImageService } from '@core/services/upload-image.service';
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

export class UserProfilePageComponent extends BaseComponent implements OnInit {
    constructor(
        private userService: UserService,
        public notificationService: NotificationService,
        private uploadImageService: UploadImageService,
        private confirmationWindowService: ConfirmationWindowService,
    ) {
        super();
    }

    public clickEvent = new EventEmitter<void>();

    public imageUrl?: string;

    public user: IUser;

    public userForm: FormGroup;

    public timeFormatValues = Object.values(TimeFormat);

    public dateFormatValues = Object.values(DateFormat);

    public languageValues = Object.values(Language);

    public timeZoneValues = Object.values(TimeZone);

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

        this.userService.getCurrentUserById(2)
            .pipe(this.untilThis)
            .subscribe((user) => {
                this.user = user;
                this.userForm.patchValue({
                    userName: user.userName,
                    phone: user.phone?.substr(user.phone.length - 10),
                    country: user.country,
                    dateFormat: user.dateFormat,
                    timeFormat: user.timeFormat,
                    language: user.language,
                    timeZone: user.timeZone,
                    image: user.image,
                });
                this.imageUrl = user.image;
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

        this.userService.editUser(editedUser)
            .pipe(this.untilThis)
            .subscribe(
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

    public loadImage(event: Event) {
        const target = event.target as HTMLInputElement;
        const fileToUpload: File = (target.files as FileList)[0];

        if (fileToUpload.size / 1000000 > 5) {
            this.confirmCancelDialog();

            return;
        }

        const formData = new FormData();

        formData.append('image', fileToUpload, fileToUpload.name);

        this.uploadImageService
            .uploadImage(formData)
            .pipe(this.untilThis)
            .subscribe(
                (resp: any) => {
                    this.imageUrl = resp.imagePath;
                },
                () => {
                    this.notificationService.showErrorMessage('Something went wrong. Picture was not uploaded.');
                },
            );
    }

    public confirmCancelDialog(): void {
        this.confirmationWindowService
            .openConfirmDialog({
                buttonsOptions: [{
                    class: 'confirm-accept-button',
                    label: 'Ok',
                    onClickEvent: this.clickEvent }],
                title: 'Oops...',
                message: 'Image can\'t be heavier than 5MB!' });
    }
}
