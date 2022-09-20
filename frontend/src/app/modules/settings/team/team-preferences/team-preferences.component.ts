import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import {
    AbstractControl,
    AsyncValidatorFn,
    FormControl,
    FormGroup,
    ValidationErrors,
    Validators,
} from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { IImagePath } from '@core/models/IImagePath';
import { ITeam } from '@core/models/ITeam';
import { ConfirmationWindowService } from '@core/services/confirmation-window.service';
import { NotificationService } from '@core/services/notification.service';
import { SettingPageService } from '@core/services/setting-page.service';
import { TeamService } from '@core/services/team.service';
import { textFieldRegex } from '@shared/constants/model-validation';
import { debounceIntervalMedium } from '@shared/constants/rxjs-constants';
import { invalidCharactersMessage } from '@shared/constants/shared-messages';
import { debounceTime, delay, finalize, map, Observable, of, switchMap, tap } from 'rxjs';

@Component({
    selector: 'app-team-preferences',
    templateUrl: './team-preferences.component.html',
    styleUrls: ['./team-preferences.component.sass'],
})
export class TeamPreferencesComponent extends BaseComponent implements OnInit {
    @Input() showDeleteButton: boolean = true;

    @Input() submitButtonText?: string;

    @Output() submitClick: EventEmitter<void> = new EventEmitter();

    @Output() deleteClick: EventEmitter<FormGroup> = new EventEmitter();

    public team?: ITeam;

    public imageUrl?: string;

    public image?: FormData;

    public clickEvent = new EventEmitter<void>();

    public formGroup: FormGroup;

    public nameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(textFieldRegex),
    ]);

    public pageLinkControl: FormControl = new FormControl('', [Validators.required], [this.teamLinkValidator()]);

    public descriptionControl: FormControl = new FormControl('', [
        Validators.maxLength(300),
        Validators.pattern(textFieldRegex),
    ]);

    invalidCharactersMessage = invalidCharactersMessage;

    public formValueUpdating = false;

    constructor(
        private teamService: TeamService,
        public notificationService: NotificationService,
        private confirmationWindowService: ConfirmationWindowService,
        private settingsPageService: SettingPageService,
    ) {
        super();
    }

    public ngOnInit(): void {
        this.formGroup = new FormGroup({
            name: this.nameControl,
            logo: new FormControl(),
            pageLink: this.pageLinkControl,
            timeZone: new FormControl(),
            description: this.descriptionControl,
        });

        this.subscribeToFormUpdates();

        if (!this.submitButtonText) {
            this.settingsPageService.updateButtonClickEvent$
                .pipe(this.untilThis)
                .subscribe({
                    next: () =>
                        this.submitClick.emit(),
                    error: () =>
                        this.notificationService.showErrorMessage('Something went wrong during team saving'),
                });
            this.formGroup.statusChanges.subscribe(() => {
                this.settingsPageService.updateButtonActive(!this.formGroup.invalid && !this.formGroup.pending);
            });
        }
    }

    public subscribeToFormUpdates() {
        this.formGroup.get('name')?.valueChanges
            .pipe(
                this.untilThis,
                tap(() => {
                    this.formValueUpdating = true;
                }),
                debounceTime(debounceIntervalMedium),
                switchMap((newTeamName: string) =>
                    this.getUniquePageLink(newTeamName).pipe(
                        finalize(() => {
                            this.formValueUpdating = false;
                        }),
                    )),
            )
            .subscribe((newLink) => this.formGroup.patchValue({ pageLink: newLink }));
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
        this.getImagePreview(target);

        if (this.submitButtonText) {
            this.image = formData;

            return;
        }
        this.uploadLogo(formData);
    }

    public confirmCancelDialog(): void {
        this.confirmationWindowService.openConfirmDialog({
            buttonsOptions: [
                {
                    class: 'confirm-accept-button',
                    label: 'Ok',
                    onClickEvent: this.clickEvent,
                },
            ],
            title: 'Oops...',
            message: "Image can't be heavier than 5MB!",
        });
    }

    public markTimeZoneDirty() {
        this.formGroup.get('timeZone')?.markAsDirty();
    }

    public trimInputValue(control: FormControl) {
        control.patchValue(removeExcessiveSpaces(control.value));
    }

    public clearLogo() {
        if (this.team?.id && this.imageUrl) {
            this.teamService.deleteLogo(this.team.id)
                .pipe(this.untilThis)
                .subscribe();
        }
        this.image = undefined;
        this.imageUrl = '';
    }

    private uploadLogo(formData: FormData) {
        this.teamService
            .uploadLogo(formData, this.team?.id)
            .pipe(this.untilThis)
            .subscribe({
                next: (resp: IImagePath) => {
                    this.imageUrl = resp.path;
                },
                error: () => {
                    this.notificationService.showErrorMessage('Something went wrong. Picture was not uploaded.');
                },
            });
    }

    private getUniquePageLink(teamName: string) {
        return this.teamService.getNewPageLink(this.team ? this.team.id : 0, teamName.replace(/\s/g, ''));
    }

    private teamLinkValidator(): AsyncValidatorFn {
        return (control: AbstractControl): Observable<ValidationErrors | null> =>
            of(control.value).pipe(
                delay(debounceIntervalMedium),
                switchMap((value) =>
                    this.teamService
                        .validatePageLink(value, this.team?.id)
                        .pipe(map((isValidLink) => (isValidLink ? null : { teamLinkUniq: true })))),
            );
    }

    private getImagePreview(target: HTMLInputElement) {
        if (!target.files || !target.files[0]) {
            return;
        }
        const file = target.files[0];

        const reader = new FileReader();

        reader.onload = () => {
            this.imageUrl = reader.result as string;
        };

        reader.readAsDataURL(file);
    }
}
