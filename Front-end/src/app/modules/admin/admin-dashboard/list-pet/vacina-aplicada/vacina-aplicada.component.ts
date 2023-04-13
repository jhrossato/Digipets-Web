import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute } from '@angular/router';
import { ApiService } from 'src/app/core/services/api.service';
import { AdicionarVacinasComponent } from 'src/app/shared/dialog/adicionar-vacinas/adicionar-vacinas.component';
import { RemoveComponent } from 'src/app/shared/dialog/remove/remove.component';

interface Vacina {
  id: number,
  dataAplicacao: string,
  dose: number,
  vacina: {
    id: number
    nome: string,
    tipo: string,
  }

}


@Component({
  selector: 'app-vacina-aplicada',
  templateUrl: './vacina-aplicada.component.html',
  styleUrls: ['./vacina-aplicada.component.scss']
})
export class VacinaAplicadaComponent implements OnInit, OnChanges {
  dataSource: MatTableDataSource<Vacina> = new MatTableDataSource<Vacina>([]);
  displayedColumns: string[] = ['vacina', 'dose', 'data', 'btn'];
  @Input() id!: number;
  constructor(
    private route: ActivatedRoute,
    public dialog: MatDialog,
    public apiService: ApiService) {
  }
  ngOnInit() {
    // console.log(this.id)
    this.petVacina()
  }

  ngOnChanges(changes: SimpleChanges) {
    // console.log(changes)
  }

  petVacina() {
    this.apiService.getV2(`/Animal/${this.id}/Vacinas`).subscribe(data => {

      this.dataSource.data = data
    })
  }

  openDialogVacinas(data: any) {
    console.log(data)
    this.dialog.open(AdicionarVacinasComponent, {
      data: data,
    })
  }

  dialogRemoveVacina(data: Vacina) {
    const edit = this.dialog.open(RemoveComponent, {
      minWidth: '420px',
    });
    edit.afterClosed().subscribe((valor) => {
      if (valor) {
        this.removePetVacina(data.id)
      }
    });
  }
  removePetVacina(id: number) {
    this.apiService.delete(`/VacinaAplicada/${id}`).subscribe({
      next: () => this.petVacina(),
    })
  }
}
