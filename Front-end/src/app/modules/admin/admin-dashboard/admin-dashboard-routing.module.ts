import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin-dashboard.component';
import { PetComponent } from './pet/pet.component';
import { TutorComponent } from './tutor/tutor.component';
import { VacinaComponent } from './vacina/vacina.component';

const routes: Routes = [

  {
    path: '', component: AdminDashboardComponent, children: [
      { path: 'tutor', component: TutorComponent },
      { path: 'pet', component: PetComponent },
      { path: 'vacina', component: VacinaComponent },
    ]
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminDashboardRoutingModule { }
