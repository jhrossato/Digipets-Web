import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';

interface Food {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-escolher-veterinario',
  templateUrl: './escolher-veterinario.component.html',
  styleUrls: ['./escolher-veterinario.component.scss']
})

export class EscolherVeterinarioComponent {
  veterinario: any
  constructor(
    public dialogRef: MatDialogRef<EscolherVeterinarioComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {

  }
  onNoClick(): void {
    console.log
    if (this.veterinario != null) {
      this.dialogRef.close(true);
    }
  }

}
