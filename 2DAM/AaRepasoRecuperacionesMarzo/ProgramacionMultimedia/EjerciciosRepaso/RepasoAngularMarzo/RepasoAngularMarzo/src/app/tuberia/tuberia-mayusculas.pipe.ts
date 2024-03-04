import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'tuberiaMayusculas'
})
export class TuberiaMayusculasPipe implements PipeTransform {

  transform(mensaje: String): String {
    return mensaje.toUpperCase();

  }

}
