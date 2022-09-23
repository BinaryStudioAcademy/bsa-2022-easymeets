import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ExternalScheduleState } from '@core/enums/external-schedule-state.enum';
import { getDefaultSchedule } from '@core/helpers/default-schedule-helper';
import { getDisplayDuration, getInputSettings } from '@core/helpers/display-duration-helper';
import { LocationTypeMapping } from '@core/helpers/location-type-mapping';
import { getScheduleItems } from '@core/helpers/schedule-list-helper';
import { removeExcessiveSpaces } from '@core/helpers/string-helper';
import { IAvailabilitySlot } from '@core/models/IAvailabilitySlot';
import { IDuration } from '@core/models/IDuration';
import { IInputSettings } from '@core/models/save-availability-slot/IInputSettings';
import { ISchedule } from '@core/models/schedule/ISchedule';
import { AvailabilitySlotService } from '@core/services/availability-slot.service';
import { NotificationService } from '@core/services/notification.service';
import { UserService } from '@core/services/user.service';
import { emailRegex, textFieldRegex } from '@shared/constants/model-validation';
import { invalidCharactersMessage } from '@shared/constants/shared-messages';
import { GeneralKeys, InputFieldType } from '@shared/enums/custom-field';
import { LocationType } from '@shared/enums/locationType';
import { concatMap } from 'rxjs';

@Component({
    selector: 'app-schedule-external',
    templateUrl: './schedule-external.component.html',
    styleUrls: ['./schedule-external.component.sass'],
})
export class ScheduleExternalComponent extends BaseComponent {
    state: ExternalScheduleState = ExternalScheduleState.ScheduleDefining;

    link: string;

    slot?: IAvailabilitySlot;

    schedule: ISchedule = getDefaultSchedule(true);

    emailPattern = emailRegex;

    textFieldRegex = textFieldRegex;

    invalidCharactersMessage = invalidCharactersMessage;

    locations: LocationType[];

    durations: IDuration[] = getDisplayDuration();

    durationKey = { inputType: InputFieldType.Duration, field: GeneralKeys.size };

    inputSettings: { [type: string]: IInputSettings } = getInputSettings();

    inputValues: { [type: string]: number } = {};

    keys = Object.keys(InputFieldType);

    locationTypeMapping = LocationTypeMapping;

    LocationType = LocationType;

    constructor(
        private router: Router,
        private activatedRoute: ActivatedRoute,
        private notificationsService: NotificationService,
        private slotService: AvailabilitySlotService,
        private userService: UserService,
    ) {
        super();
        activatedRoute.params.subscribe((params) => {
            this.link = params['link'];
            this.getSlotFromLink();
        });
    }

    nextClicked() {
        this.state = ExternalScheduleState.EmailDefining;
    }

    doneClicked() {
        this.slotService
            .updateScheduleExternally(this.link, this.schedule)
            .pipe(this.untilThis)
            .pipe(concatMap(() => this.updateSlotExternally()))
            .subscribe(
                () => {
                    this.state = ExternalScheduleState.Done;
                },
                () => {
                    this.notificationsService.showErrorMessage('Something went wrong, try defining schedule again');
                    this.returnToSchedule();
                },
            );
    }

    returnToSchedule() {
        this.state = ExternalScheduleState.ScheduleDefining;
    }

    meetingNameChanged(value: string) {
        if (this.slot) {
            this.slot.name = removeExcessiveSpaces(value);
        }
    }

    onDurationChange(key: InputFieldType, field: keyof typeof GeneralKeys) {
        this.inputSettings[key].isCustom = this.inputSettings[key].durationValue?.time === 'Custom';
        this.updateDuration(field, this.inputSettings[key].durationValue?.minutes ?? 0);
    }

    updateDuration(field: keyof typeof GeneralKeys, value: number) {
        if (this.slot) {
            this.slot[field] = value;
        }
    }

    private initLocations() {
        this.userService
            .getUserMeetIntegrations()
            .pipe(this.untilThis)
            .subscribe((locations) => {
                this.locations = locations.concat(LocationType.Office);
            });
    }

    private getSlotFromLink() {
        this.slotService
            .getByLink(this.link)
            .pipe(this.untilThis)
            .subscribe((slot) => {
                if (!slot) {
                    this.notificationsService.showErrorMessage('Link is invalid or not unique');
                    this.router.navigate(['/availability']);

                    return;
                }
                this.slot = slot;
                this.schedule = {
                    ...slot.schedule,
                    scheduleItems: getScheduleItems(),
                };
                this.initLocations();
                this.defineCurrentInputValues();
                this.defineDuration();
            });
    }

    private defineDuration() {
        this.keys.forEach((el) => {
            const duration =
                this.durations.find((x) => x.minutes === this.inputValues[this.inputSettings[el].inputType]) ??
                this.durations.find((x) => x.time === 'Custom');

            this.inputSettings[el] = {
                ...this.inputSettings[el],
                durationValue: duration,
            };

            if (duration?.time === 'Custom') {
                this.inputSettings[el] = {
                    ...this.inputSettings[el],
                    isCustom: true,
                    inputValue: String(this.inputValues[this.inputSettings[el].inputType]),
                };
            }
        });
    }

    private defineCurrentInputValues() {
        if (this.slot) {
            this.inputValues[InputFieldType.Duration] = this.slot.size;
        }
    }

    private async updateSlotExternally() {
        if (this.slot) {
            this.slotService
                .updateSlotExternally(this.link, this.slot)
                .pipe(this.untilThis)
                .subscribe(() => {});
        }
    }
}
