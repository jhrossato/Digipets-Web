import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidenavComponent } from './components/layout/sidenav/sidenav.component';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatDividerModule } from '@angular/material/divider';
import { MatListModule } from '@angular/material/list';
import { MatExpansionModule } from '@angular/material/expansion';
import { RouterModule } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { MatDialog, MatDialogModule } from '@angular/material/dialog'; // Adiciona esta importação
import { EscolherVeterinarioComponent } from './dialog/escolher-veterinario/escolher-veterinario.component';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatSelectModule } from '@angular/material/select';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { AdicionarVacinasComponent } from './dialog/adicionar-vacinas/adicionar-vacinas.component';
import { CalendarModule } from 'primeng/calendar';
import { DropdownModule } from 'primeng/dropdown';
import { InputTextModule } from 'primeng/inputtext';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatIconModule } from '@angular/material/icon';
import { MatNativeDateModule } from '@angular/material/core';
import { MatInputModule } from '@angular/material/input';
import { CheckboxModule } from 'primeng/checkbox';
import { RadioButtonModule } from 'primeng/radiobutton';
import { VacinasComponent } from './dialog/vacinas/vacinas.component';
import { RemoveComponent } from './dialog/remove/remove.component';
import { EditTutorComponent } from './dialog/edit-tutor/edit-tutor.component';
import { EditPetComponent } from './dialog/edit-pet/edit-pet.component';
import {MatButtonModule} from '@angular/material/button';
import { InputNumberModule } from 'primeng/inputnumber';
import { NgxMaskDirective, NgxMaskPipe, provideNgxMask } from 'ngx-mask';
import { PasswordModule } from 'primeng/password';
@NgModule({
  declarations: [SidenavComponent, AdicionarVacinasComponent, EscolherVeterinarioComponent, VacinasComponent, RemoveComponent, EditTutorComponent, EditPetComponent],
  imports: [
    CommonModule,
    MatSidenavModule,
    MatDividerModule,
    MatListModule,
    MatExpansionModule,
    RouterModule,
    MatToolbarModule,
    MatCardModule,
    MatDialogModule,
    MatAutocompleteModule,
    MatSelectModule,
    FormsModule,
    ButtonModule,
    ReactiveFormsModule,
    CalendarModule,
    DropdownModule,
    InputTextModule,
    MatDatepickerModule,
    MatIconModule,
    MatNativeDateModule,
    MatInputModule,
    CheckboxModule,
    RadioButtonModule,
    MatButtonModule,
    InputNumberModule,
    NgxMaskDirective,
    NgxMaskPipe,
    PasswordModule
  ],
  exports: [SidenavComponent, AdicionarVacinasComponent,  EscolherVeterinarioComponent],
  providers: [MatDialog, provideNgxMask()]
})
export class SharedModule { }
