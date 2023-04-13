import { Component, EventEmitter, Input, OnInit, Output, Inject } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { ApiService } from 'src/app/core/services/api.service';
interface Pet {
  nome: string,
  tutorId: number,
  especie: string,
  genero: string,
  porte: string,
  raca: string,
  pelagem: string,
  castrado: boolean,
  observacao: string
  nascimento: string
}
@Component({
  selector: 'app-edit-pet',
  templateUrl: './edit-pet.component.html',
  styleUrls: ['./edit-pet.component.scss']
})
export class EditPetComponent implements OnInit {
  formPet = this._fb.group({
    nome: ['', { validators: [Validators.required] }],
    id: [0, { validators: [Validators.required] }],
    tutorId: [0, { validators: [Validators.required] }],
    especie: ['', { validators: [Validators.required] },],
    genero: ['', { validators: [Validators.required] },],
    porte: ['', { validators: [Validators.required] },],
    raca: ['', { validators: [Validators.required] },],
    nascimento: ['', { validators: [Validators.required] },],
    pelagem: ['', { validators: [Validators.required] },],
    castrado: [false, { validators: [Validators.required] },],
    observacao: ['', { validators: [Validators.required] },],
  });

  currentRoute: string | undefined;
  constructor(
    public dialogRef: MatDialogRef<EditPetComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private apiService: ApiService,
    private _fb: NonNullableFormBuilder,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    if (typeof this.data != "number") {
      this.formPet.setValue({
        id: this.data.id,
        nome: this.data.nome,
        tutorId: this.data.tutorId,
        especie: this.data.especie,
        genero: this.data.genero,
        porte: this.data.porte,
        raca: this.data.raca,
        pelagem: this.data.pelagem,
        castrado: this.data.castrado,
        observacao: this.data.observacao,
        nascimento: this.data.nascimento
      })
    }
    this.formPet.get('genero')?.valueChanges.subscribe(v =>{
      console.log(v)
    })
  }

  submitForm() {

    if (this.formPet.valid) {
      if (typeof this.data != "number") {
        this.apiService.put(this.formPet.value, '/Animal').subscribe({
          next: () => this.dialogRef.close(true),
          error: (x) => console.log(x)
        })
      } else {
        this.apiService.post(this.formPet.value, `/Tutor/${this.data}/Animais`).subscribe({
          next: () => this.dialogRef.close(true),
          error: (x) => console.log(x)
        })
      }
    }
  }
  isDataNumber(): boolean {
    return typeof this.data === 'number';
  }
}
