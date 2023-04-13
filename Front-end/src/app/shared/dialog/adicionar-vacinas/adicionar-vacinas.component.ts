import { ChangeDetectorRef, Component, Input, OnInit, Inject } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ApiService } from 'src/app/core/services/api.service';
type vacina = {
  id: number,
  tipo: string,
  nome: string
}
@Component({
  selector: 'app-adicionar-vacinas',
  templateUrl: './adicionar-vacinas.component.html',
  styleUrls: ['./adicionar-vacinas.component.scss']
})
export class AdicionarVacinasComponent implements OnInit {
  vacinas: any;
  setVacina!: vacina;
  @Input() petId!: number;
  date!: Date;
  formVacinasApli = this._fb.group({
    dose: [0, { validators: [Validators.required, Validators.min(1)] }],
    dataAplicacao: ["", { validators: [Validators.required] }],
    animalId: [0, { validators: [Validators.required] }],
    vacinaId: [0, { validators: [Validators.required] }],

  });

  constructor(
    public dialogRef: MatDialogRef<AdicionarVacinasComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private _fb: NonNullableFormBuilder,
    private apiService: ApiService,
    private cdr: ChangeDetectorRef
  ) { }

  ngOnInit() {

    this.apiService.getV2('/Vacina').subscribe((response) => {
      this.vacinas = response;
      this.cdr.detectChanges();
    });

    if (typeof this.data != "number") {
      this.formVacinasApli.setValue({
        dose: this.data.dose,
        dataAplicacao: this.data.dataAplicacao,
        animalId: this.data.id,
        vacinaId: this.data.vacina.id,
      })
    } else {
      this.formVacinasApli.get('animalId')?.setValue(this.data)
    }
  }

  submitForm() {
    this.setvacina()

    if (this.formVacinasApli.valid) {
      if (typeof this.data == "number") {
        this.apiService.post(this.formVacinasApli.value, `/Animal/${this.formVacinasApli.get('animalId')?.value}/Vacinas`).subscribe({
          next: () => this.dialogRef.close(),
          error: (x) => console.log(x)
        })
      } else {
        this.apiService.put(this.formVacinasApli.value, `/VacinaAplicada/${this.formVacinasApli.get('animalId')?.value}`).subscribe({
          next: () => this.dialogRef.close(),
          error: (x) => console.log(x)
        })
      }
    }
  }

  setvacina() {
    if (this.setVacina) {
      this.formVacinasApli.get('vacinaId')?.setValue(this.setVacina.id);
    }
  }
  isDataNumber(): boolean {
    return typeof this.data === 'number';
  }
}
