import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';
import { AuthComponent } from './auth.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { ReactiveFormsModule } from '@angular/forms';
import { RegistrationComponent } from './registration/registration.component';
import { MatStepperModule } from '@angular/material/stepper';
import { HttpClientModule } from '@angular/common/http';
import { ApiService } from 'src/app/core/services/api.service';
import { InputTextModule } from 'primeng/inputtext';
import { MatDialogModule } from '@angular/material/dialog';
import { NgxMaskDirective, NgxMaskPipe, provideNgxMask } from 'ngx-mask';
@NgModule({
  declarations: [LoginComponent, AuthComponent, RegistrationComponent],
  imports: [
    CommonModule,
    AuthRoutingModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    ReactiveFormsModule,
    MatStepperModule,
    HttpClientModule,
    InputTextModule,
    MatDialogModule,
    NgxMaskPipe,
    NgxMaskDirective
  ], providers: [ApiService,  provideNgxMask()]
})
export class AuthModule { }
