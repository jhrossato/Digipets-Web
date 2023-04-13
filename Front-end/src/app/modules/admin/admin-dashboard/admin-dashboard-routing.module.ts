import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin-dashboard.component';
import { VacinaComponent } from './vacina/vacina.component';
import { NewPetComponent } from './new-pet/new-pet.component';
import { ListTutorComponent } from './list-tutor/list-tutor.component';
import { ListPetComponent } from './list-pet/list-pet.component';

const routes: Routes = [
  {
    path: '', component: AdminDashboardComponent, children: [
      { path: 'cadastros', component: NewPetComponent },
      { path: 'tutores', component: ListTutorComponent },
      { path: 'pets/:id', component: ListPetComponent },
      { path: 'vacinas', component: VacinaComponent },
    ]
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminDashboardRoutingModule { }
