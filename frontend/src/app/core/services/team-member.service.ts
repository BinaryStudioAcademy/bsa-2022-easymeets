import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class TeamMemberService {
    teamId: number = 0;

    private teamIdChangedSource = new BehaviorSubject<number>(this.teamId);

    public teamIdChangedEmitted$ = this.teamIdChangedSource.asObservable();

    setTeamId(data: number) {
        this.teamIdChangedSource.next(data);
    }
}
