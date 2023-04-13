import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from 'src/app/core/services/api.service';
import { AdicionarVacinasComponent } from 'src/app/shared/dialog/adicionar-vacinas/adicionar-vacinas.component';
import { EditPetComponent } from 'src/app/shared/dialog/edit-pet/edit-pet.component';
import { RemoveComponent } from 'src/app/shared/dialog/remove/remove.component';
import { VacinasComponent } from 'src/app/shared/dialog/vacinas/vacinas.component';

interface Pet {
  id: number
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
  selector: 'app-list-pet',
  templateUrl: './list-pet.component.html',
  styleUrls: ['./list-pet.component.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      transition('expanded <=> collapsed', animate('125ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class ListPetComponent implements OnInit {
  displayedColumns: string[] = [
    "nome",
    "especie",
    "genero",
    "porte",
    "raca",
    "pelagem",
    "castrado",
    "observacao",
    "nascimento",
    "btn"
  ];
  petId!: number
  vete = 5
  dataSource: MatTableDataSource<Pet> = new MatTableDataSource<Pet>([]);
  columnsToDisplay = ['nome', 'especie', 'genero'];
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: Pet | null | undefined;
  id!: Number
  vacinas: any
  constructor(private route: ActivatedRoute, public dialog: MatDialog, public apiService: ApiService) {

  }
  /*   applyFilter(event: Event) {
      const filterValue = (event.target as HTMLInputElement).value;
      this.dataSource.filter = filterValue.trim().toLowerCase();
    } */
  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const id = params.get('id');
      if (id !== null) {
        this.id = parseInt(id);
      }
    });
    this.allPet()
  }

  dialogEditPet(data: Pet) {
    const edit = this.dialog.open(EditPetComponent, {
      minWidth: '520px',
      data: data
    });
    edit.afterClosed().subscribe(() => {
      this.allPet();
    });
  }
  dialogRemovePet(data: Pet) {
    const edit = this.dialog.open(RemoveComponent, {
      minWidth: '420px',
    });
    edit.afterClosed().subscribe((valor) => {
      if (valor) {
        this.removePet(data.id)
      }
    });
  }

  dialogCreatePet() {
    const edit = this.dialog.open(EditPetComponent, {
      minWidth: '420px',
      data: this.id
    });
    edit.afterClosed().subscribe(() => {
      this.allPet();
    });
  }

  removePet(id: number) {
    this.apiService.delete(`/Animal/${id}`).subscribe({
      next: () => this.allPet(),

    })
  }

  allPet() {
    this.apiService.getV2(`/Tutor/${this.id}/Animais`).subscribe(data => {
      this.dataSource.data = data
    })

  }

  openDialogVacinas(id: number) {
    const dialog = this.dialog.open(AdicionarVacinasComponent, {
      data: id,
    })
    dialog.afterClosed().subscribe(() => {
      this.allPet();
    });
  }
}
