import { Component } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-vacina',
  templateUrl: './vacina.component.html',
  styleUrls: ['./vacina.component.scss']
})
export class VacinaComponent {
  formPet = this._fb.group({
    nome: ['', { validators: [Validators.required] }],
    tipo: ['', { validators: [Validators.required] },],
    dose: ['', { validators: [Validators.required] },],
    dataAplicacao: ['', { validators: [Validators.required] },],
  });
  constructor(private _fb: NonNullableFormBuilder) { }

  submitForm() {
    console.log(this.formPet.value)
  }
}
