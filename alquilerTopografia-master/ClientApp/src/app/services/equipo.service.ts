import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HandleHttpErrorService } from '../@base/servicio/handle-http-error.service';
import { Equipo } from '../clientes/models/equipo';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class EquipoService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Equipo[]> {
    return this.http.get<Equipo[]>(this.baseUrl + 'api/Equipo')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Equipo[]>('Consultar Equipo', null))
      );
  }
  post(equipo: Equipo): Observable<Equipo> {
    return this.http.post<Equipo>(this.baseUrl + 'api/Equipo', equipo)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Equipo>('Registrar Equipo', null))
      );
  }
}
