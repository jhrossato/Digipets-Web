import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-remove',
  templateUrl: './remove.component.html',
  styleUrls: ['./remove.component.scss']
})
export class RemoveComponent  {
  constructor(
    public dialogRef: MatDialogRef<RemoveComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) { }


}
