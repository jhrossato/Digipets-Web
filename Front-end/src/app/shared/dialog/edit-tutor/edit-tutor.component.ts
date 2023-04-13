import { Component, OnInit, Output, Input, EventEmitter, Inject } from '@angular/core';
import { FormBuilder, NonNullableFormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ApiService } from 'src/app/core/services/api.service';
import { cep } from 'src/app/modules/admin/admin-dashboard/new-pet/tutor/tutorDTO';
import { celularValidator, cpfValidator, nomeValidator, rgValidator, senhaValidator } from '../../validator/validator';


@Component({
  selector: 'app-edit-tutor',
  templateUrl: './edit-tutor.component.html',
  styleUrls: ['./edit-tutor.component.scss']
})
export class EditTutorComponent {

  formTutor = this._fb.group({
    id: [0, { validators: [Validators.required] }],
    veterinarioId: [0, { validators: [Validators.required] }],
    nome: ['', { validators: [Validators.required,Validators.minLength(16), nomeValidator] }],
    email: ['', { validators: [Validators.required, Validators.email] },],
    cpf: ['', { validators: [Validators.required, cpfValidator] },],
    rg: ['', { validators: [Validators.required, rgValidator] },],
    senha: ['', { validators: [Validators.required, senhaValidator] },],
    telefone: ['', { validators: [Validators.required] },],
    endereco: this._fb.group({
      id: [0, { validators: [Validators.required] }],
      cep: ['', { validators: [Validators.required] },],
      bairro: ['', { validators: [Validators.required] },],
      rua: ['', { validators: [Validators.required] },],
      numero: ['', { validators: [Validators.required] },],
      cidade: ['', { validators: [Validators.required] },],
      estado: ['', { validators: [Validators.required] },]
    }),

  });
  constructor(
    public dialogRef: MatDialogRef<EditTutorComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private _fb: FormBuilder,
    private apiService: ApiService
  ) { }

  ngOnInit() {
    this.formTutor.get("endereco.cep")?.valueChanges.subscribe((valor: any) => {
      if (valor.length == 8) {
        this.apiService.getCep(valor).subscribe((data) => {
          this.setCept(data)
        })
      }
    })
    if (typeof this.data != "number") {
      this.formTutor.setValue({
        id: this.data.id,
        veterinarioId: this.data.veterinarioId,
        nome: this.data.nome,
        email: this.data.email,
        cpf: this.data.cpf,
        rg: this.data.rg,
        senha: this.data.senha,
        endereco: {
          id: this.data.id,
          cep: this.data.endereco.cep,
          bairro: this.data.endereco.bairro,
          rua: this.data.endereco.rua,
          numero: this.data.endereco.numero,
          cidade: this.data.endereco.cidade,
          estado: this.data.endereco.estado

        },
        telefone: this.data.telefone,
      })
    } else {
      this.formTutor.get("veterinarioId")?.setValue(this.data)
    }
  }
  submitForm() {
    if (this.formTutor.valid) {
      if (typeof this.data != "number") {
        this.apiService.put(this.formTutor.value, `/Tutor`).subscribe({
          next: () => this.dialogRef.close(true),
          error: (x) => console.log(x)
        })
      }
      else {
        console.log(this.formTutor.value)
        this.apiService.post(this.formTutor.value, `/Veterinario/${this.formTutor.get("veterinarioId")?.value}/Tutores`).subscribe({
          next: () => this.dialogRef.close(),
          error: (x) => console.log(x)
        })
      }
    }
  }
  setCept(params: cep) {
    this.formTutor.get('endereco')?.setValue({
      id: this.formTutor.get("endereco.id")?.value!,
      cep: params.cep,
      rua: params.bairro,
      cidade: params.localidade,
      estado: params.uf,
      bairro: params.bairro,
      numero: ''
    })
  }
  isDataNumber(): boolean {
    return typeof this.data === 'number';
  }
}
