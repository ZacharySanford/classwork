import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';

// appConfig object identifies things that you are using that are not part of the base Angular
// (the router is not required for basic Angular processing)
//
// the providers attribute is a list of optional Angular processes you are using
// provideRouter indicates you want Angular to provide router support using the import specified

export const appConfig: ApplicationConfig = {
  providers: [provideRouter(routes)]
};
