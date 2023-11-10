import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'tuberia'
})
export class TuberiaPipe implements PipeTransform {

  transform(value: string): number {
    const fechaPublicacion = new Date(value);
    console.log(fechaPublicacion)
    const fechaActual = new Date()
    const diferencia = fechaActual.getFullYear() - fechaPublicacion.getFullYear()
    return diferencia
  }

}
