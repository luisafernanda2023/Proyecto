import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ClienteConsultaComponent } from './clientes/consultarCliente/cliente-consulta/cliente-consulta.component';
import { ClienteRegistroComponent } from './clientes/registrarCliente/cliente-registro/cliente-registro.component';
import { EquipoConsultaComponent } from './equipos/consultarEquipo/equipo-consulta/equipo-consulta.component';
import { EquipoRegistroComponent } from './equipos/registrarEquipo/equipo-registro/equipo-registro.component';
import { AppRoutingModule } from './app-routing.module';
import { ClienteService } from './services/cliente.service';
import { EquipoService } from './services/equipo.service';
import { FiltroEquipoPipe } from './pipe/equipo/filtro-equipo.pipe';
import { FiltroclientePipe } from './pipe/cliente/filtrocliente.pipe';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from './@base/modal/alert-modal/alert-modal.component';
import { MarcaModalComponent } from './@base/marca-modal/marca-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ClienteConsultaComponent,
    ClienteRegistroComponent,
    EquipoConsultaComponent,
    EquipoRegistroComponent,
    FiltroEquipoPipe,
    FiltroclientePipe,
    AlertModalComponent,
    MarcaModalComponent
  ],
  imports: [
    ReactiveFormsModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' }
    ]),
    AppRoutingModule,
    ReactiveFormsModule,
    NgbModule
  ],
  entryComponents: [AlertModalComponent, MarcaModalComponent],
  providers: [ClienteService, EquipoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
