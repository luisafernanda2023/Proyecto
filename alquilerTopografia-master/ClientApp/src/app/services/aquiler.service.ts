import { Injectable, Inject } from '@angular/core';
import { Alquiler } from '../clientes/models/alquiler';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { HandleHttpErrorService } from '../@base/servicio/handle-http-error.service';

@Injectable({
  providedIn: 'root'
})
export class AquilerService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Alquiler[]> {
    return this.http.get<Alquiler[]>(this.baseUrl + 'api/Alquiler')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Alquiler[]>('Consultar Alquiler', null))
      );
  }
  post(alquiler: Alquiler): Observable<Alquiler> {
    return this.http.post<Alquiler>(this.baseUrl + 'api/Alquiler', alquiler)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Alquiler>('Registrar Alquiler', null))
      );
  }
}
