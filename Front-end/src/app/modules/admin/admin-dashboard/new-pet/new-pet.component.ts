import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../../../core/services/api.service';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { EscolherVeterinarioComponent } from 'src/app/shared/dialog/escolher-veterinario/escolher-veterinario.component';
import { AdicionarVacinasComponent } from 'src/app/shared/dialog/adicionar-vacinas/adicionar-vacinas.component';

@Component({
  selector: 'app-new-pet',
  templateUrl: './new-pet.component.html',
  styleUrls: ['./new-pet.component.scss']
})
export class NewPetComponent implements OnInit {
  veterianrioId!: number;
  tutorId!: number
  petId!: number
  constructor(private apiService: ApiService, public dialog: MatDialog) {

  }
  ngOnInit() {
   /*  this.apiService.getV2('/Veterinario').subscribe((data) => {
      const veterinarioSelect = this.dialog.open(EscolherVeterinarioComponent, {
        disableClose: true,
        minWidth: '420px',
        data: data
      });
      console.log(veterinarioSelect)
      veterinarioSelect.afterClosed().subscribe(result => {
        this.veterianrioId = result
      });
    }) */
  }
  setTutorId(tutorId: number) {
    this.tutorId = tutorId
  }
  setPetId(petId: number) {
    this.petId = petId
  }

  openDialogVacinas() {
    this.dialog.open(AdicionarVacinasComponent, {
      data: this.petId,
      disableClose: true,
    })
  }
}
