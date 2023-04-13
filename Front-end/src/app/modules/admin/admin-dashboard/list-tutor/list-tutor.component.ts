import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { ApiService } from 'src/app/core/services/api.service';
import { EditTutorComponent } from 'src/app/shared/dialog/edit-tutor/edit-tutor.component';
import { RemoveComponent } from 'src/app/shared/dialog/remove/remove.component';
import { VacinasComponent } from 'src/app/shared/dialog/vacinas/vacinas.component';
import { JwtHelperService } from '@auth0/angular-jwt';
type Vacina = {
  id: number,
  tipo: string,
  nome: string
}
export interface Tutor {
  id: number,
  nome: string,
  email: string,
  senha: string,
  telefone: string,
  endereco: {
    id: number,
    rua: string,
    numero: number,
    bairro: string,
    cidade: string,
    estado: string,
    cep: string
  },
  cpf: string,
  rg: string,
  veterinarioId: number
}

@Component({
  selector: 'app-list-tutor',
  templateUrl: './list-tutor.component.html',
  styleUrls: ['./list-tutor.component.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      transition('expanded <=> collapsed', animate('125ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class ListTutorComponent implements OnInit {

  dataSource: MatTableDataSource<Tutor> = new MatTableDataSource<Tutor>([]);
  columnsToDisplay = ['nome', 'email', 'telefone'];
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: Tutor | null | undefined;
  userId!: number

  constructor(
    private jwtHelper: JwtHelperService,
    private router: Router,
    public dialog: MatDialog,
    public apiService: ApiService
  ) {

  }
  ngOnInit(): void {
    this.allTutore()
    this.getUserIdFromToken()

  }

  dialogEditTutor(data: Vacina) {
    const edit = this.dialog.open(EditTutorComponent, {
      minWidth: '420px',
      data: data
    })
    edit.afterClosed().subscribe((valor) => {

        this.allTutore();
     
    });
  }
  dialogCreateTutor() {
    const edit = this.dialog.open(EditTutorComponent, {
      minWidth: '420px',
      data: this.userId
    })
    edit.afterClosed().subscribe((valor) => {

        this.allTutore();

    });
  }

  dialogRemoveTutor(data: Vacina) {
    const edit = this.dialog.open(RemoveComponent, {
      minWidth: '420px',
      data: this.userId
    })
    edit.afterClosed().subscribe((valor) => {
      if (valor) {
        this.removeTutore(data.id);
      }
    });
  }

  allTutore() {
    this.apiService.getV2("/Tutor").subscribe(data => {
      console.log(data)
      this.dataSource.data = data;
    })
  }
  removeTutore(id: number) {
    this.apiService.delete(`/Tutor/${id}`).subscribe({
      next: () => this.allTutore()
    })
  }
  tablePet(id: number) {
    this.router.navigate(['/admin/pets', id]);
  }

  getUserIdFromToken() {
    const token = localStorage.getItem('token');
    const decodedToken = this.jwtHelper.decodeToken(token!);
    this.userId = parseInt(decodedToken.id);;
    console.log(this.userId)
  }
}
