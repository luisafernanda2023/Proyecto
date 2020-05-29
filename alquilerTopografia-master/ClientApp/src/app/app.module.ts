import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ClienteConsultaComponent } from './clientes/consultarCliente/cliente-consulta/cliente-consulta.component';
import { ClienteRegistroComponent } from './clientes/registrarCliente/cliente-registro/cliente-registro.component';
import { EquipoConsultaComponent } from './equipos/consultarEquipo/equipo-consulta/equipo-consulta.component';
import { EquipoRegistroComponent } from './equipos/registrarEquipo/equipo-registro/equipo-registro.component';
import { AppRoutingModule } from './app-routing.module';
import { ClienteService } from './services/cliente.service';
import { EquipoService } from './services/equipo/equipo.service';
import { FiltroEquipoPipe } from './pipe/equipo/filtro-equipo.pipe';
import { FiltroclientePipe } from './pipe/cliente/filtrocliente.pipe';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from './@base/modal/alert-modal/alert-modal.component';
import { EquipoReactivoComponent } from './equipos/reactivo/equipo-reactivo/equipo-reactivo.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ClienteConsultaComponent,
    ClienteRegistroComponent,
    EquipoConsultaComponent,
    EquipoRegistroComponent,
    FiltroEquipoPipe,
    FiltroclientePipe,
    AlertModalComponent,
    EquipoReactivoComponent
  ],
  imports: [
    ReactiveFormsModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ]),
    AppRoutingModule,
    ReactiveFormsModule,
    NgbModule
  ],
  entryComponents: [AlertModalComponent],
  providers: [ClienteService, EquipoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
