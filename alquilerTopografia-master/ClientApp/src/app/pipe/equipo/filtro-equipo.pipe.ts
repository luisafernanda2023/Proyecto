import { Pipe, PipeTransform } from '@angular/core';
import { Equipo } from 'src/app/clientes/models/equipo';

@Pipe({
  name: 'filtroEquipo'
})
export class FiltroEquipoPipe implements PipeTransform {

  transform(equipo: Equipo[], searchText: string): any {
    if (searchText == null) return equipo;
    return equipo.filter(p =>
    p.nombre.toLowerCase()
    .indexOf(searchText.toLowerCase()) !== -1);
  }

}
