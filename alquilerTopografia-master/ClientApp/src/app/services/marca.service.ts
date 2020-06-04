import { Injectable, Inject } from '@angular/core';
import { catchError, tap } from 'rxjs/operators';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { HandleHttpErrorService } from '../@base/servicio/handle-http-error.service';
import { Observable } from 'rxjs';
import { Marca } from '../clientes/models/marca';

const httpOptions = { 
  headers: new HttpHeaders({ 'Content-Type': 'application/json' }) 
};

@Injectable({
  providedIn: 'root'
})
export class MarcaService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Marca[]> {
    return this.http.get<Marca[]>(this.baseUrl + 'api/Marca')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Marca[]>('Consultar Marca', null))
      );
  }
  post(marca: Marca): Observable<Marca> {
    return this.http.post<Marca>(this.baseUrl + 'api/Marca', marca, httpOptions)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Marca>('Registrar Marca', null))
      );
  }
}
