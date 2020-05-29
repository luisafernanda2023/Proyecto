import { Component, OnInit } from '@angular/core';
import { Equipo } from '../../models/equipo';
import { EquipoService } from 'src/app/services/equipo/equipo.service';


@Component({
  selector: 'app-equipo-consulta',
  templateUrl: './equipo-consulta.component.html',
  styleUrls: ['./equipo-consulta.component.css']
})
export class EquipoConsultaComponent implements OnInit {

  equipos: Equipo[];
  searchText: String;
  constructor(private equipoService: EquipoService) { }
  ngOnInit() {
    this.equipoService.get().subscribe(result => {
      this.equipos = result;
    });
  }
}
