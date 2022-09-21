import { Component, EventEmitter, Input, Output } from '@angular/core';
import { naturalNumberRegex } from '@shared/constants/model-validation';
import { UnitOfTime } from '@shared/enums/unitOfTime';

@Component({
    selector: 'app-custom-time',
    templateUrl: './custom-time.component.html',
    styleUrls: ['./custom-time.component.sass'],
})
export class CustomTimeComponent {
    @Output() changeValueEmitter = new EventEmitter<number>();

    @Input() public inputCustomTime: string;

    public naturalNumberInputPattern = naturalNumberRegex;

    public unitOfTime = Object.keys(UnitOfTime);

    public selectedUnit: string = this.unitOfTime[0];

    customDurationChanged() {
        const valueSize: number =
            UnitOfTime[this.selectedUnit as UnitOfTime] === UnitOfTime.Hour
                ? parseInt(this.inputCustomTime, 10) * 60
                : parseInt(this.inputCustomTime, 10);

        this.changeValueEmitter.emit(valueSize);
    }
}
