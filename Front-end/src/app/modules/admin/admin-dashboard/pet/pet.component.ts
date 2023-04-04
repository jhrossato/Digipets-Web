import { Component } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-pet',
  templateUrl: './pet.component.html',
  styleUrls: ['./pet.component.scss']
})
export class PetComponent {
  formPet = this._fb.group({
    nome: ['', { validators: [Validators.required] }],
    especie: ['', { validators: [Validators.required] },],
    genero: ['', { validators: [Validators.required] },],
    porte: ['', { validators: [Validators.required] },],
    raca: ['', { validators: [Validators.required] },],
    nascimento: ['', { validators: [Validators.required] },],
    pelagem: ['', { validators: [Validators.required] },],
    castrado: ['', { validators: [Validators.required] },],
    observacao: ['', { validators: [Validators.required] },],
  });
  constructor(private _fb: NonNullableFormBuilder) { }

  submitForm() {
    console.log(this.formPet.value)
  }
}
