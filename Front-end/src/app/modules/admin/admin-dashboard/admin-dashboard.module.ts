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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatStepperModule } from '@angular/material/stepper';
import { VacinaComponent } from './vacina/vacina.component';
import { ApiService } from 'src/app/core/services/api.service';
import { NewPetComponent } from './new-pet/new-pet.component';
import { InputTextModule } from 'primeng/inputtext';
import { NgxMaskDirective, NgxMaskPipe, provideNgxMask } from 'ngx-mask';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { RadioButtonModule } from 'primeng/radiobutton';
import { DropdownModule } from 'primeng/dropdown';
import { CalendarModule } from 'primeng/calendar';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { TutorComponent } from './new-pet/tutor/tutor.component';
import { PetComponent } from './new-pet/pet/pet.component';
import { ListPetComponent } from './list-pet/list-pet.component';
import { ListTutorComponent } from './list-tutor/list-tutor.component';
import { VacinaAplicadaComponent } from './list-pet/vacina-aplicada/vacina-aplicada.component';
import { JWT_OPTIONS, JwtHelperService } from '@auth0/angular-jwt';

@NgModule({
  declarations: [AdminDashboardComponent, TutorComponent, VacinaComponent, PetComponent, NewPetComponent, ListPetComponent, ListTutorComponent, VacinaAplicadaComponent],
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
    MatStepperModule,
    InputTextModule,
    NgxMaskDirective,
    NgxMaskPipe,
    MatAutocompleteModule,
    RadioButtonModule,
    DropdownModule,
    CalendarModule,
    FormsModule,
    MatTableModule,
    MatIconModule,
    MatButtonModule

  ],
  providers: [TaskService, ApiService, JwtHelperService, provideNgxMask(),  { provide: JWT_OPTIONS, useValue: JWT_OPTIONS }],
})
export class AdminDashboardModule { }
