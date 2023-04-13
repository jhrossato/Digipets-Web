import { ChangeDetectorRef, Component, Input, OnInit, Inject } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ApiService } from 'src/app/core/services/api.service';

interface data {
  id: number,
  tipo: string,
  nome: string,
}
@Component({
  selector: 'app-vacinas',
  templateUrl: './vacinas.component.html',
  styleUrls: ['./vacinas.component.scss']
})
export class VacinasComponent implements OnInit {
  formVacina = this._fb.group({
    id: [0, { validators: [Validators.required] }],
    tipo: ['', { validators: [Validators.required] }],
    nome: ['', { validators: [Validators.required] }],
  });

  constructor(
    public dialogRef: MatDialogRef<VacinasComponent>,
    @Inject(MAT_DIALOG_DATA) public data: data,
    private _fb: NonNullableFormBuilder,
    private apiService: ApiService,
    private cdr: ChangeDetectorRef
  ) { }
  ngOnInit(): void {
    if (this.data) {
      this.formVacina.setValue({
        id: this.data.id,
        tipo: this.data.tipo,
        nome: this.data.nome
      })
    }
  }
  createVacina() {
    if (this.formVacina.valid) {
      this.apiService.post(this.formVacina.value, '/Vacina').subscribe(valor => {
        this.dialogRef.close();
      })
    }
  }
  editVacina() {
    if (this.formVacina.valid) {
      this.apiService.put(this.formVacina.value, `/Vacina/${this.formVacina.get("id")?.value}`).subscribe(valor => {
        this.dialogRef.close();
      })
    }
  }
}
