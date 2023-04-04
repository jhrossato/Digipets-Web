import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminDashboardRoutingModule } from './admin-dashboard-routing.module';
import { AdminDashboardComponent } from './admin-dashboard.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { TaskService } from 'src/app/core/services/task.service';
import { HttpClientModule } from '@angular/common/http';
import { MatInputModule } from '@angular/material/input';
import { MatRadioModule } from '@angular/material/radio';
import { MatCardModule } from '@angular/material/card';
import { MatToolbarModule } from '@angular/material/toolbar';
import { ReactiveFormsModule } from '@angular/forms';
import { MatStepperModule } from '@angular/material/stepper';
import { TutorComponent } from './tutor/tutor.component';
import { VacinaComponent } from './vacina/vacina.component';
import { PetComponent } from './pet/pet.component';
@NgModule({
  declarations: [AdminDashboardComponent, TutorComponent, VacinaComponent, PetComponent],
  imports: [
    CommonModule,
    AdminDashboardRoutingModule,
    SharedModule,
    HttpClientModule,
    MatInputModule,
    MatRadioModule,
    MatCardModule,
    MatToolbarModule,
    ReactiveFormsModule,
    MatStepperModule
  ],
  providers: [TaskService],
})
export class AdminDashboardModule { }
