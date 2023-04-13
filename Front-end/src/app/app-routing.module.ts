import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './core/guards/can-active.guard';
import { NoAuthGuard } from './core/guards/noAuth.guard';

const routes: Routes = [
  {
    path: '',
    loadChildren: () =>
      import('./modules/auth/auth.module').then((m) => m.AuthModule),
    canActivate: [NoAuthGuard]
  },
  {
    path: 'admin',
    loadChildren: () =>
      import('./modules/admin/admin-dashboard/admin-dashboard.module').then(
        (m) => m.AdminDashboardModule
      ),
    canActivate: [AuthGuard]
  },
  {
    path: 'user',
    loadChildren: () =>
      import('./modules/user/user-dashboard/user-dashboard.module').then(
        (m) => m.UserDashboardModule
      ),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  providers: [NoAuthGuard],
  exports: [RouterModule],
})
export class AppRoutingModule { }
