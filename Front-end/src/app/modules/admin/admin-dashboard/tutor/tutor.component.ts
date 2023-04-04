import { Component } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-tutor',
  templateUrl: './tutor.component.html',
  styleUrls: ['./tutor.component.scss']
})
export class TutorComponent {
  formPet = this._fb.group({
    nome: ['', { validators: [Validators.required] }],
    cpf: ['', { validators: [Validators.required] },],
    telefone: ['', { validators: [Validators.required] },],
    cep: ['', { validators: [Validators.required] },],
    rua: ['', { validators: [Validators.required] },],
    numero: ['', { validators: [Validators.required] },],
    bairro: ['', { validators: [Validators.required] },],
    cidade: ['', { validators: [Validators.required] },],
    estado: ['', { validators: [Validators.required] },],
  });
  constructor(private _fb: NonNullableFormBuilder) { }

  submitForm() {
    console.log(this.formPet.value)
  }
}
