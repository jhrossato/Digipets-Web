import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { IMenu } from 'src/app/core/interfaces/IMenu';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss'],
})
export class SidenavComponent {
  @Input() navigationMenu: IMenu[] | undefined;
  showFiller = true;
 constructor(private router: Router){

 }
  sair() {
    localStorage.removeItem('token');
    window.location.reload();
    this.router.navigate(['']);
  }
}
