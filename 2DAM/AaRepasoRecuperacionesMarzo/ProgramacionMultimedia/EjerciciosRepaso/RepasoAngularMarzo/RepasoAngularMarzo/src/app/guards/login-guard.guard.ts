import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { LoginService } from '../servicios/servicioLogin/login.service';

export const loginGuardGuard: CanActivateFn = (route, state) => {
  if(inject(LoginService).estaLogueado()){
    return true;
  } else {
   inject(Router).navigate(["/login"]);
    return false;
  }
};
