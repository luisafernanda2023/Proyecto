import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { ClienteConsultaComponent } from './clientes/consultarCliente/cliente-consulta/cliente-consulta.component';
import { ClienteRegistroComponent } from './clientes/registrarCliente/cliente-registro/cliente-registro.component';
import { EquipoConsultaComponent } from './equipos/consultarEquipo/equipo-consulta/equipo-consulta.component';
import { EquipoRegistroComponent } from './equipos/registrarEquipo/equipo-registro/equipo-registro.component';

const routes: Routes = [
  {
    path: 'clienteConsulta',
    component: ClienteConsultaComponent
  },
  {
    path: 'clienteRegistro',
    component: ClienteRegistroComponent
  },
  {
    path: 'equipoConsulta',
    component: EquipoConsultaComponent
  },
  {
    path: 'equipoRegistro',
    component: EquipoRegistroComponent
  }
];


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
