import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, AsyncValidatorFn, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ITeam } from '@core/models/ITeam';
import { NotificationService } from '@core/services/notification.service';
import { TeamService } from '@core/services/team.service';
import { TimeZone } from '@shared/enums/timeZone';
import { map, Observable } from 'rxjs';

@Component({
    selector: 'app-team-preferences',
    templateUrl: './team-preferences.component.html',
    styleUrls: ['./team-preferences.component.sass'],
})
export class TeamPreferencesComponent extends BaseComponent implements OnInit {
    @Input() public team?: ITeam;

    @Input() showDeleteButton: boolean = true;

    @Input() submitButtonText: string;

    @Output() submitClick: EventEmitter<void> = new EventEmitter();

    @Output() deleteClick: EventEmitter<FormGroup> = new EventEmitter();

    public formGroup: FormGroup;

    public timeZoneValues = Object.values(TimeZone);

    public nameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(/^[іІїЇaєЄa-zA-Z\dа-яА-Я-]+(\s|)[іІїЇєЄa-zA-Z\dа-яА-Я-]*$/),
    ]);

    public pageLinkControl: FormControl = new FormControl(
        '',
        [Validators.required],
        [this.teamLinkValidator()],
    );

    public descriptionControl: FormControl = new FormControl(
        '',
        [
            Validators.required,
            Validators.minLength(2),
            Validators.maxLength(50),
            Validators.pattern(/^[.,іІїЇaєЄa-zA-Z\dа-яА-Я-\s]*$/)],
    );

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private teamService: TeamService,
        public notificationService: NotificationService,
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
    }

    public generateNewPageLink(formGroup: FormGroup) {
        if (formGroup.value.name.length > 0) {
            this.getUniquePageLink(formGroup.value.name);
        }
    }

    private getUniquePageLink(teamName: string) {
        this.teamService
            .getNewPageLink(this.team ? this.team.id : 0, teamName.replace(/\s/g, ''))
            .pipe(this.untilThis)
            .subscribe((res) => {
                this.formGroup.patchValue({
                    pageLink: res,
                });
            });
    }

    private teamLinkValidator(): AsyncValidatorFn {
        return (control: AbstractControl): Observable<ValidationErrors | null> =>
            this.validateTeamLink(control.value)
                .pipe(this.untilThis)
                .pipe(
                    map((response) => (response ? null : { teamLinkUniq: true })),
                );
    }

    private validateTeamLink(teamLink: string): Observable<boolean> {
        return this.teamService.validatePageLink(this.team?.id, teamLink);
    }
}
