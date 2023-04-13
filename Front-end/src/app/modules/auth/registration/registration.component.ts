import { Component, Inject, Input } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ApiService } from 'src/app/core/services/api.service';
import { cpfValidator, nomeValidator, rgValidator, senhaValidator } from 'src/app/shared/validator/validator';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss'],
})
export class RegistrationComponent {
  formVeterinario = this._fb.group({

    nome: ['', { validators: [Validators.required, nomeValidator] }],
    email: ['', { validators: [Validators.required, Validators.email] },],
    cpf: ['', { validators: [Validators.required, cpfValidator] },],
    rg: ['', { validators: [Validators.required, rgValidator] },],
    senha: ['', { validators: [Validators.required, senhaValidator] },],
    telefone: ['', { validators: [Validators.required] },],
    crmv: ['', { validators: [Validators.required] },],
    endereco: this._fb.group({
      cep: ['', { validators: [Validators.required] },],
      bairro: ['', { validators: [Validators.required] },],
      rua: ['', { validators: [Validators.required] },],
      numero: [3, { validators: [Validators.required] },],
      cidade: ['', { validators: [Validators.required] },],
      estado: ['', { validators: [Validators.required] },]
    }),
  });
  constructor(
    private apiService: ApiService,
    public dialogRef: MatDialogRef<RegistrationComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private _fb: NonNullableFormBuilder) { }

  submitForm() {
    if (this.formVeterinario.valid) {
      this.apiService.post(this.formVeterinario.valid, "/Veterinario").subscribe(data => {
        console.log(data)
      })
    }
  }
}
