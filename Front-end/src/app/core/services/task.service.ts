import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TaskService {
  constructor(private httpClient: HttpClient) {}

  getList<T>(url: string) {
    // console.log(url)
    return this.httpClient.get<T[]>(url).pipe();
  }
}
