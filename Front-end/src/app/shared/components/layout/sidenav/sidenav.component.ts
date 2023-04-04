import { Component, Input } from '@angular/core';
import { IMenu } from 'src/app/core/interfaces/IMenu';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss'],
})
export class SidenavComponent {
  @Input() navigationMenu: IMenu[] | undefined;
  showFiller = true;
}
