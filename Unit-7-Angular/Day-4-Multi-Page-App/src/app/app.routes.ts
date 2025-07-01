import { Routes }        from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { SampleFormComponent } from './components/sample-form/sample-form.component';
import { StateSealsComponent } from './components/state-seals/state-seals.component';
import { StudentListComponent } from './components/student-list/student-list.component';

// The Routes object is an array of objects to associate a URL path  to a component.
//
// Each entry in the array contains the following attributes:
//
// path - the URL path to be associated with a component
// component - name of the import for the component associate with the path
// redirect - optional attribute to redirect a URL path to a different page
// pathMatch - indicates if a full match to a URL path is necessary to use this entry
//
// We are defining an object called routes with a data type of Routes
// We tell the router the name of the array with routes that
//
export const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' }, // empty path should redirect to /home
    {path: 'home', component: HomeComponent}, // /home should display the HomeComponent
    {path: 'sampleform', component:SampleFormComponent},
    {path: 'stateseals', component:StateSealsComponent},
    {path: 'studentlist', component:StudentListComponent}
];
