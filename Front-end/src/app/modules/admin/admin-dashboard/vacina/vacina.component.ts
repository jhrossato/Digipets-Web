import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { ApiService } from 'src/app/core/services/api.service';
import { RemoveComponent } from 'src/app/shared/dialog/remove/remove.component';
import { VacinasComponent } from 'src/app/shared/dialog/vacinas/vacinas.component';

type Vacina = {
  id: number,
  tipo: string,
  nome: string
}


@Component({
  selector: 'app-vacina',
  templateUrl: './vacina.component.html',
  styleUrls: ['./vacina.component.scss']
})
export class VacinaComponent implements OnInit {
  displayedColumns: string[] = ['tipo', 'nome', 'btn'];
  dataSource = new MatTableDataSource();

  constructor(private apiService: ApiService, public dialog: MatDialog) {

  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  ngOnInit() {
    this.allVacina()
  }
  dialogEditVacina(data: Vacina) {
    const dialog = this.dialog.open(VacinasComponent, {
      minWidth: '420px',
      data: data
    });
    dialog.afterClosed().subscribe(result => {
      this.allVacina()
    });
  }
  dialogCreateVacina() {
    const dialog = this.dialog.open(VacinasComponent, {
      minWidth: '420px',
    });
    dialog.afterClosed().subscribe(result => {
      this.allVacina()
    });
  }
  dialogRemoveVacina(data: Vacina) {
    const dialog = this.dialog.open(RemoveComponent, {
      minWidth: '420px',
    });
    dialog.afterClosed().subscribe(result => {
      if (result) {
        this.removeVacina(data.id)
      }
    });
  }
  removeVacina(id: number) {
    this.apiService.delete(`/Vacina/${id}`).subscribe(valor => {
      this.allVacina()
    })
  }
  allVacina() {
    this.apiService.getV2('/Vacina').subscribe(valor => {
      this.dataSource.data = valor
    })
  }
}
