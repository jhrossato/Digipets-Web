import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserDashboardRoutingModule } from './user-dashboard-routing.module';
import { UserDashboardComponent } from './user-dashboard.component';
import { MatToolbarModule } from '@angular/material/toolbar';

@NgModule({
  declarations: [
    UserDashboardComponent
  ],
  imports: [
    CommonModule,
    UserDashboardRoutingModule,
    MatToolbarModule
  ]
})
export class UserDashboardModule { }
