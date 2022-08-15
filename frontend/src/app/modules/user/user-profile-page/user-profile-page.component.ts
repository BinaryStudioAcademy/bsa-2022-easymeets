import { Component } from '@angular/core';

@Component({
    selector: 'app-user-profile-page',
    templateUrl: './user-profile-page.component.html',
    styleUrls: ['./user-profile-page.component.sass'],
})
export class UserProfilePageComponent {
    public imageUrl: string;

    public imageFile: File;

    public loadImage(target: any) {
        // eslint-disable-next-line no-debugger
        debugger;
        // eslint-disable-next-line prefer-destructuring
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';

            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            target.value = '';
            console.log('Image can\'t be heavier than ~5MB');
        }

        const reader = new FileReader();

        reader.addEventListener(
            'load',
            () => {
                // eslint-disable-next-line no-debugger
                debugger;
                this.imageUrl = reader.result as string;
                console.log(this.imageUrl);
            },
        );
        reader.readAsDataURL(this.imageFile);
    }
}
