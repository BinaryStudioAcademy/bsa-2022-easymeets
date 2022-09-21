import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class TeamMemberService {
    teamId: number = 0;

    private teamIds = new BehaviorSubject<number>(this.teamId);

    public teamIdChangedEmitted$ = this.teamIds.asObservable();

    addNode(data: number) {
        this.teamIds.next(data);
    }
}
