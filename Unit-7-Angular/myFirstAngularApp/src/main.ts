// This starts the angular application
// When you do 'ng serve' it looks for main.ts to start app
// This is where you define the component representing the home page

import { bootstrapApplication } from '@angular/platform-browser'; // Starts the Angular app
import { appConfig } from './app/app.config'; // Angular app configuration information

// Specify the folder containing the homepage and it's name

// import {name-used-in-this-code} from 'path-to-the-component-files'
// The component path contains folder and high-level name of the component
// The component path is relative to the src folder
// ./app/app
//
// . - the folder you are in (src folder)
// /app - the folder named app in the folder you are in
// /app - all files related to the component will start with 'app'
//                            .component is assumed
// The name of the import must match an export class in the TypeScript file
import { AppComponent } from './app/app.component'; // Get the angular components from './app/app

// bootstrapApplication function is what the Angular server calls to start the app
// Give it: (name-of-import-for-component, configuration
bootstrapApplication(AppComponent, appConfig)
  .catch((err) => console.error(err));
