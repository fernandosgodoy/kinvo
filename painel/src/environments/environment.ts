// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  //Firebase authinfo here....
  firebase: {
    apiKey: "AIzaSyDCHJCEZAD1iWzqb7R4IdFmvYTcFHCZBmA",
    authDomain: "kinvo-demo.firebaseapp.com",
    projectId: "kinvo-demo",
    storageBucket: "kinvo-demo.appspot.com",
    messagingSenderId: "288688236911",
    appId: "1:288688236911:web:3c257a99d6cc801e1f609a"

  }
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
