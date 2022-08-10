import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
    selector: 'app-calendars-page',
    templateUrl: './calendars-page.component.html',
    styleUrls: ['./calendars-page.component.sass'],
})
export class CalendarsPageComponent {
    toppings = new FormControl('');

    toppingList: string[] = ['Extra cheese', 'Mushroom', 'Onion', 'Pepperoni', 'Sausage', 'Tomato'];

    public displayedColumns: string[] = ['$implicit', 'index', 'count', 'first', 'last', 'even', 'odd'];

    public data: string[] = ['one', 'two', 'three', 'four', 'five'];
}
