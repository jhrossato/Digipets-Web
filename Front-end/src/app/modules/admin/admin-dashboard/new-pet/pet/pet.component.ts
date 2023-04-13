import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { NonNullableFormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ApiService } from 'src/app/core/services/api.service';

@Component({
  selector: 'app-pet',
  templateUrl: './pet.component.html',
  styleUrls: ['./pet.component.scss']
})
export class PetComponent implements OnInit {
  @Input() tutorId!: number
  @Input() next: any;
  @Output() petId = new EventEmitter<number>();

  formPet = this._fb.group({
    nome: ['', { validators: [Validators.required] }],
    tutorId: [8, { validators: [Validators.required] }],
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
  constructor(private apiService: ApiService, private _fb: NonNullableFormBuilder, private route: ActivatedRoute) { }
  ngOnInit() {
    this.currentRoute = this.route.snapshot.url.join('/');
    console.log(this.currentRoute); // imprime a rota atual no console
  }

  submitForm() {
    // this.formPet.get('tutorId')?.setValue(this.tutorId)
    console.log(this.formPet.value)
    if (this.formPet.valid) {
      this.apiService.post(this.formPet.value, `/Tutor/${this.formPet.get("tutorId")?.value}/Animais`).subscribe((data) => {
        console.log(data)
        this.petId.emit(data.id)
        this.next.next()

      })
    }
  }
}
