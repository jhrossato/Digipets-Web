import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminDashboardRoutingModule } from './admin-dashboard-routing.module';
import { AdminDashboardComponent } from './admin-dashboard.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { TaskService } from 'src/app/core/services/task.service';
import { HttpClientModule } from '@angular/common/http';
import { RegisterPetComponent } from './pet/register-pet/register-pet.component';


@NgModule({
  declarations: [AdminDashboardComponent, RegisterPetComponent],
  imports: [
    CommonModule,
    AdminDashboardRoutingModule,
    SharedModule,
    HttpClientModule,
  ],
  providers: [TaskService],
})
export class AdminDashboardModule {}
