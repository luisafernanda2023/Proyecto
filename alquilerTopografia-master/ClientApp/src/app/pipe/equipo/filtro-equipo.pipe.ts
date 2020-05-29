import { Pipe, PipeTransform } from '@angular/core';
import { Equipo } from 'src/app/equipos/models/equipo';

@Pipe({
  name: 'filtroEquipo'
})
export class FiltroEquipoPipe implements PipeTransform {

  transform(equipo: Equipo[], searchText: string): any {
    if (searchText == null) return equipo;
    return equipo.filter(p =>
    p.nEquipo.toLowerCase()
    .indexOf(searchText.toLowerCase()) !== -1);
  }

}
