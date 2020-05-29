import { Pipe, PipeTransform } from '@angular/core';
import { Cliente } from 'src/app/clientes/models/cliente';

@Pipe({
  name: 'filtrocliente'
})
export class FiltroclientePipe implements PipeTransform {

  transform(cliente: Cliente[], searchText: string): any {
    if (searchText == null) return cliente;
    return cliente.filter(p =>
    p.nCliente.toLowerCase()
    .indexOf(searchText.toLowerCase()) !== -1);
  }

}
