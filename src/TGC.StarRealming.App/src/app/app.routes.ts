import { Routes } from '@angular/router';
import { MsalGuard } from '@azure/msal-angular';
import { ProfileComponent } from './pages/profile/profile.component';

export const routes: Routes = [
  {
    path: 'profile',
    component: ProfileComponent,
    canActivate: [MsalGuard],
  },
];
