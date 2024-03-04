import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'tuberia'
})
export class TuberiaPipe implements PipeTransform {

  transform(fechaPublicacion: Date): Number {
    let fechaActual = new Date();
    let diferencia = fechaActual.getTime() - fechaPublicacion.getTime();
    let anos = new Date(diferencia).getFullYear() - 1970;
    return anos;
  }

}
