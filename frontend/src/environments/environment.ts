// This file can be replaced during build by using the `fileReplacements` array.
// `ng build` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
    production: false,
    appUrl: 'http://localhost:4200/',
    coreUrl: 'http://localhost:5050',
    notifierUrl: 'http://localhost:5070',
    firebase: {
        apiKey: 'AIzaSyAF5LeybBJklic1uhIpenfDYoNvuH3mSqY',
        authDomain: 'easymeets-4ed60.firebaseapp.com',
        projectId: 'easymeets-4ed60',
        storageBucket: 'easymeets-4ed60.appspot.com',
        messagingSenderId: '681019224003',
        appId: '1:681019224003:web:f114bfb64139e3146a1776',
        measurementId: 'G-CZQ7Z16TJZ',
    },
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.
