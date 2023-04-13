import { Component, OnInit, Output, Input, EventEmitter } from '@angular/core';
import { FormBuilder, NonNullableFormBuilder, Validators } from '@angular/forms';
import { ApiService } from 'src/app/core/services/api.service';
import { cep } from './tutorDTO';
import { celularValidator, cpfValidator, nomeValidator, rgValidator, senhaValidator } from 'src/app/shared/validator/validator';

@Component({
  selector: 'app-tutor',
  templateUrl: './tutor.component.html',
  styleUrls: ['./tutor.component.scss']
})
export class TutorComponent implements OnInit {
  @Input() veterinarioId!: number;
  @Input() next: any;

  @Output() tutortId = new EventEmitter<number>();

  formPet = this._fb.group({
    veterinarioId: [0, { validators: [Validators.required] }],
    nome: ['', { validators: [Validators.required, nomeValidator] }],
    email: ['', { validators: [Validators.required, Validators.email] },],
    cpf: ['', { validators: [Validators.required, cpfValidator] },],
    rg: ['', { validators: [Validators.required, rgValidator] },],
    senha: ['', { validators: [Validators.required, senhaValidator] },],
    telefone: ['', { validators: [Validators.required] },],
    endereco: this._fb.group({
      cep: ['', { validators: [Validators.required] },],
      bairro: ['', { validators: [Validators.required] },],
      rua: ['', { validators: [Validators.required] },],
      numero: ['', { validators: [Validators.required] },],
      cidade: ['', { validators: [Validators.required] },],
      estado: ['', { validators: [Validators.required] },]
    }),
  });
  constructor(private _fb: FormBuilder, private apiService: ApiService) { }
  ngOnInit() {
    this.formPet.get("endereco.cep")?.valueChanges.subscribe((valor: any) => {
      if (valor.length == 8) {
        this.apiService.getCep(valor).subscribe((data) => {
          this.setCept(data)
        })
      }
    })
  }
  submitForm() {
    this.formPet.get('veterinarioId')?.setValue(this.veterinarioId)
    this.formPet.get('senha')?.setValue("Qq12345*")
    console.log(this.formPet)
    if (this.formPet.valid) {
      this.formPet.get('senha')?.setValue(this.formPet.get('cpf')!.value)
      this.apiService.post(this.formPet.value, `/Veterinario/${this.veterinarioId}/Tutores`).subscribe((data) => {
        this.next.next()
        this.tutortId.emit(data.id)

      })
    }
  }
  setCept(params: cep) {
    this.formPet.get('endereco')?.setValue({
      cep: params.cep,
      rua: params.bairro,
      cidade: params.localidade,
      estado: params.uf,
      bairro: params.bairro,
      numero: ''


    })

  }


}
