import { CanActivateFn, Router } from '@angular/router';
import { LoginServicioService } from './servicios/login-servicio.service';
import { inject } from '@angular/core';

export const authGuardGuard: CanActivateFn = (route, state) => {
  const loginService: LoginServicioService= inject(LoginServicioService);
  const router: Router = inject(Router);

  if(loginService.estaLogeadoEnUsuario()) {
    return true;
  }else{
    router.navigate(['/login']);
    return false;
  }
};
