import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, AsyncValidatorFn, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { ISaveEventDetails } from '@core/models/save-availability-slot/ISaveEventDetails';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { environment } from '@env/environment';
import { map, Observable } from 'rxjs';

@Component({
    selector: 'app-event-detail',
    templateUrl: './event-detail.component.html',
    styleUrls: ['./event-detail.component.sass'],
})
export class EventDetailComponent extends BaseComponent implements OnInit {
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

    public formGroup: FormGroup;

    public slotLinkControl = new FormControl('', [Validators.required], [this.slotLinkValidator()]);

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

    constructor(private slotService: AvailabilitySlotService) {
        super();
    }

    ngOnInit(): void {
        this.settings = {
            timeZoneVisibility: false,
            link: '',
            welcomeMessage: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
            language: 'English',
            bookingsPerDay: this.allowedBooking[1],
            passwordProtectionIsUsed: false,
            passwordProtection: '',
        };
        this.formGroup = new FormGroup({ link: this.slotLinkControl });
    }

    onLinkChange() {
        this.settings.link = this.slotLinkControl.value ?? '';
        this.linkChange.emit(this.settings.link);
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
}
