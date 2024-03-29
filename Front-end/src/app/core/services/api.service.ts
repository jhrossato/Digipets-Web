import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private url = "https://digipetswebapi.azurewebsites.net"
  constructor(private http: HttpClient) { }



  getV1(params: any, address: string): Observable<any> {
    const endpoint = this.url.concat(address)
    return this.http.get<any>(endpoint, params)
  }
  getV2(address: string): Observable<any> {
    const endpoint = this.url.concat(address)
    return this.http.get<any>(endpoint)
  }
  post(params: any, address: string): Observable<any> {
    const endpoint = this.url.concat(address)
    return this.http.post<any>(endpoint, params)
  }
  delete(address: string): Observable<any> {
    const endpoint = this.url.concat(address)
    return this.http.delete<any>(endpoint)
  }
  put(params: any, address: string): Observable<any> {
    const endpoint = this.url.concat(address)
    return this.http.put<any>(endpoint, params)
  }
  getCep(params: string): Observable<any> {

    return this.http.get<any>(`https://viacep.com.br/ws/${params}/json/`)
  }

}
