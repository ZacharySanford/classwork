import { Routes } from '@angular/router';
import { Homepage } from './components/homepage/homepage';
import { PetDisplay } from './components/pet-display/pet-display';


export const routes: Routes = [
  {path : '', redirectTo: '/homepage', pathMatch: 'full' },
  {path : 'homepage', component: Homepage},
  {path : 'pet-display', component: PetDisplay}
];


