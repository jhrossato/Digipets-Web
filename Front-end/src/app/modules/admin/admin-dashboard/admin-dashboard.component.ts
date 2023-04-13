import { Component } from '@angular/core';
import { IMenu } from 'src/app/core/interfaces/IMenu';
import { TaskService } from 'src/app/core/services/task.service';
import { compactNavigation } from './data/navigation-data';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.scss'],
})
export class AdminDashboardComponent {
  navigation = compactNavigation;
  constructor(private httpService: TaskService) {

  }
}
