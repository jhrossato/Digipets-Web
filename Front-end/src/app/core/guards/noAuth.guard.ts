import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';


@Injectable()
export class NoAuthGuard implements CanActivate {
  constructor(private router: Router) { }

  canActivate(): boolean {
    // Verificar se o usuário está autenticado

    const token = localStorage.getItem('token');

    if (token) {
      // Usuário autenticado, redirecionar para outra rota (por exemplo, a página de dashboard)
      this.router.navigate(['/admin']);
      return false;
    } else {
      // Usuário não autenticado, permitir acesso à rota de login
      return true;
    }
  }
}
