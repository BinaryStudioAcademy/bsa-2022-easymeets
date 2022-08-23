import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { getDisplayDate } from '@core/helpers/date-helper';
import { getDisplayDuration } from '@core/helpers/display-duration-hepler';
import { INewMeetingTeamMember } from '@core/models/INewMeetingTeamMember';
import { NewMeetingService } from '@core/services/new-meeting.service';
import { naturalNumberRegex, newMeetingNameRegex } from '@shared/constants/model-validation';
import { LocationType } from '@shared/enums/locationType';

@Component({
    selector: 'app-new-meeting',
    templateUrl: './new-meeting.component.html',
    styleUrls: ['./new-meeting.component.sass'],
})
export class NewMeetingComponent implements OnInit {
    public teamMembers: INewMeetingTeamMember[];

    public durations = getDisplayDuration();

    public dates = getDisplayDate();

    public isLoading: boolean = true;

    public meetingForm: FormGroup;

    public locations = Object.keys(LocationType).filter(key => Number.isNaN(Number(key)));

    public durationValue: string;

    public customTimeShown: boolean = false;

    public meetingNameControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
        Validators.pattern(newMeetingNameRegex),
    ]);

    public customTimeControl: FormControl = new FormControl('', [
        Validators.required,
        Validators.pattern(naturalNumberRegex),
    ]);

    // eslint-disable-next-line no-unused-vars
    constructor(private newMeetingService: NewMeetingService) {
        this.getTeamMembersOfCurrentUser();
    }

    ngOnInit(): void {
        this.meetingForm = new FormGroup({
            meetingName: this.meetingNameControl,
            customTime: this.customTimeControl,
            unitOfTime: new FormControl(),
            location: new FormControl(),
            duration: new FormControl(),
            mainPageDuration: new FormControl(),
            teamMembers: new FormControl(),
        });
    }

    public getTeamMembersOfCurrentUser() {
        this.newMeetingService
            .getTeamMembersOfCurrentUser()
            .subscribe((resp) => {
                this.teamMembers = resp;
            });
    }

    public searchMember(value: string) {
        const filter = value.toLowerCase();

        return this.teamMembers.filter(option => option.name.toLowerCase().startsWith(filter));
    }

    public changeDuration(form: FormGroup) {
        this.durationValue = form.value.duration;
        if (this.durationValue === 'Custom') {
            this.customTimeShown = true;
        } else {
            this.customTimeShown = false;
        }
    }
}
