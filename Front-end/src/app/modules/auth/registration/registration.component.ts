import { Component, Input } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss'],
})
export class RegistrationComponent {
  formLogin = this._fb.group({
    name: [
      '',
      {
        validators: [
          Validators.required,
          Validators.pattern(/^[a-zA-Z ]+$/),
          Validators.minLength(8),
          Validators.maxLength(40),
        ],
      },
    ],
    email: ['', { validators: [Validators.required, Validators.email] }],
    password: [
      '',
      { validators: [Validators.required, Validators.minLength(8)] },
    ],
  });
  constructor(private _fb: NonNullableFormBuilder) {}

  onLogin() {}
}
