import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private router: Router) { }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean> | Promise<boolean> | boolean {
    const token = localStorage.getItem('token'); // substitua com a lógica para obter o token JWT do armazenamento local ou de onde você o está obtendo em seu aplicativo
    if (token) {
      // Se o token JWT estiver presente, permita a navegação para a rota protegida
      return true;
    } else {
      // Se o token JWT não estiver presente, redirecione para a página de login ou qualquer outra página conforme necessário
      this.router.navigate(['/']);
      return false;
    }
  }
}
