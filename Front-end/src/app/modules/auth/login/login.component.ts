import { Component, EventEmitter, Input, Output } from '@angular/core';
import {
  FormBuilder,
  FormGroup,
  NonNullableFormBuilder,
  Validators,
} from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ApiService } from 'src/app/core/services/api.service';
import { RegistrationComponent } from '../registration/registration.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent {
  isAuthenticated = false;
  formLogin = this._fb.group({
    email: ['', { validators: [Validators.required, Validators.email] }],
    password: [
      '',
      { validators: [Validators.required, Validators.minLength(8)] },
    ],
  });
  constructor(
    public router: Router,
    public dialog: MatDialog,
    private _fb: NonNullableFormBuilder,
    private apiService: ApiService
  ) { }

  onLogin() {
    this.apiService.post(this.formLogin.value, "/Token/Login").subscribe(
      data => {
        console.log(data)
        this.onLoginPerformed(data)
      },
      error => {
        console.log(error);
        this.isAuthenticated = true
      }
    );
  }
  onLoginPerformed(token: any) {
    window.localStorage.setItem('token', token.token);
    this.router.navigate(['/admin']);

  }
  cadastroVeterinario() {
    this.dialog.open(RegistrationComponent, {
      minHeight: "600px",
      minWidth: "450px"
    })
  }
}
