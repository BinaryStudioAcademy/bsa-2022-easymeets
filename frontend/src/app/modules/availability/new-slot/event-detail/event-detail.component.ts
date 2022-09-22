import { AfterViewInit, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import {
    AbstractControl,
    AsyncValidatorFn,
    FormControl,
    FormGroup,
    ValidationErrors,
    Validators,
} from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { removeAllSpaces, removeExcessiveSpaces } from '@core/helpers/string-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISaveEventDetails } from '@core/models/save-availability-slot/ISaveEventDetails';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { environment } from '@env/environment';
import { textFieldRegex } from '@shared/constants/model-validation';
import { invalidCharactersMessage } from '@shared/constants/shared-messages';
import { map, Observable } from 'rxjs';

@Component({
    selector: 'app-event-detail',
    templateUrl: './event-detail.component.html',
    styleUrls: ['./event-detail.component.sass'],
})
export class EventDetailComponent extends BaseComponent implements OnInit, AfterViewInit {
    @Input() set newSlot(value: IAvailabilitySlot | undefined) {
        this.slot = value;
        this.settings = {
            timeZoneVisibility: this.slot?.timeZoneVisibility ?? false,
            link: this.slot?.link ?? '',
            welcomeMessage: this.slot?.welcomeMessage ?? 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            language: this.slot?.language ?? 'English',
            bookingsPerDay: this.slot?.bookingsPerDay ?? this.allowedBooking[1],
            passwordProtectionIsUsed: this.slot?.passwordProtectionIsUsed ?? false,
            passwordProtection: this.slot?.passwordProtection ?? '',
        };
        this.slotLinkControl.patchValue(this.settings.link);
    }

    @Output() linkChange = new EventEmitter<string>();

    public appDomain = environment.appUrl;

    public slot?: IAvailabilitySlot;

    public settings: ISaveEventDetails;

    public slotLinkControl = new FormControl('', [Validators.required], [this.slotLinkValidator()]);

    public welcomeMessageControl = new FormControl('', [Validators.pattern(textFieldRegex)]);

    public passwordControl = new FormControl('', [
        Validators.pattern(textFieldRegex),
        Validators.minLength(3),
        Validators.maxLength(8),
    ]);

    public formGroup: FormGroup = new FormGroup({
        link: this.slotLinkControl,
        welcomeMessage: this.welcomeMessageControl,
        password: this.passwordControl,
    });

    public timeZoneChoices: { text: string; value: boolean }[] = [
        {
            text: 'Automatically detect and show the times in Bookers time zone',
            value: true,
        },
        {
            text: 'Lock the timezone (best for in-person events)',
            value: false,
        },
    ];

    public languages: string[] = ['English', 'Ukrainian'];

    public allowedBooking: number[] = [1, 2, 3];

    public hidePassword: boolean = false;

    public invalidCharactersMessage = invalidCharactersMessage;

    private passwordErrors: ValidationErrors | null;

    constructor(private slotService: AvailabilitySlotService) {
        super();
    }

    ngOnInit(): void {
        this.settings = {
            timeZoneVisibility: false,
            link: crypto.randomUUID(),
            welcomeMessage: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            language: 'English',
            bookingsPerDay: this.allowedBooking[1],
            passwordProtectionIsUsed: false,
            passwordProtection: '',
        };
    }

    ngAfterViewInit(): void {
        this.slotLinkControl.patchValue(this.settings.link);
    }

    onLinkChange(value: string) {
        const link = removeAllSpaces(value);

        this.slotLinkControl.patchValue(link);
        this.settings.link = link ?? '';
        this.linkChange.emit(this.settings.link);
    }

    onWelcomeMessageChange(message: string) {
        this.welcomeMessageControl.patchValue(removeExcessiveSpaces(message));
    }

    onPasswordChange() {
        if (this.settings.passwordProtection !== removeExcessiveSpaces(this.settings.passwordProtection ?? '')) {
            this.settings.passwordProtection = removeExcessiveSpaces(this.settings.passwordProtection ?? '');
        }
        this.passwordErrors = this.passwordControl.errors;
        this.passwordControl.setErrors(this.getPasswordErrors());
    }

    passwordUsageChanged() {
        if (this.settings.passwordProtectionIsUsed) {
            this.passwordControl.setErrors(this.getPasswordErrors());
        } else {
            this.passwordErrors = this.passwordControl.errors;
            this.passwordControl.setErrors(null);
            this.passwordControl.markAsUntouched();
        }
    }

    private slotLinkValidator(): AsyncValidatorFn {
        return (control: AbstractControl): Observable<ValidationErrors | null> =>
            this.validateSlotLink(control.value)
                .pipe(this.untilThis)
                .pipe(map((response) => (response ? null : { linkUnique: true })));
    }

    private validateSlotLink(teamLink: string): Observable<boolean> {
        return this.slotService.validateSlotLink(teamLink, this.slot?.id);
    }

    private getPasswordErrors() {
        return this.settings.passwordProtection
            ? this.passwordErrors
            : { ...this.passwordErrors, required: true };
    }
}
