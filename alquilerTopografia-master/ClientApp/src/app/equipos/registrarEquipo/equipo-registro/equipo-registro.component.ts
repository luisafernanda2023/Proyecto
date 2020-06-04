import { Component, OnInit } from '@angular/core';
import { Equipo } from '../../../clientes/models/equipo';
import { EquipoService } from 'src/app/services/equipo.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MarcaService } from 'src/app/services/marca.service';
import { Marca } from 'src/app/clientes/models/marca';
import { AlertModalComponent } from 'src/app/@base/modal/alert-modal/alert-modal.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-equipo-registro',
  templateUrl: './equipo-registro.component.html',
  styleUrls: ['./equipo-registro.component.css']
})
export class EquipoRegistroComponent implements OnInit {

  formGroup: FormGroup;
  equipo: Equipo;
  marcas:Marca[];

//  marcas: string[];
  constructor(
    private equipoService: EquipoService, 
    private maService:MarcaService, 
    private formBuilder: FormBuilder,
    private modalService:NgbModal) { }

  ngOnInit() {
    this.chargeMarcas();
    this.buildForm();
    /*this.marcas.push('marca1');
    this.marcas.push('marca2');
    this.marcas.push('marca3');
    this.marcas.push('marca4');*/
  }

  private chargeMarcas(){
    this.maService.get().subscribe(
      (data) => {
        if(data==null){
          const messageBox = this.modalService.open(AlertModalComponent)
          messageBox.componentInstance.title = "Resultado Operacion";
          messageBox.componentInstance.message = 'Error al traer marcas';
        }
        else{
          this.marcas = data;
        }
      },
      (error) => {
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operacion";
        messageBox.componentInstance.message = 'Error en la petición';
      }
    );
  }

  private buildForm() {
    this.formGroup = this.formBuilder.group({
      nombre:['', Validators.required],
      marca:['',Validators.required],
      valor:[0,Validators.required]
    });
  }

  add() {
    if(this.formGroup.invalid)
      return;

    this.equipo = this.formGroup.value;
    this.equipo.marca = new Marca();
    this.equipo.marca.nombre = this.formGroup.controls.marca.value;

    this.equipoService.post(this.equipo).subscribe(p => {
      if (p != null) {
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operacion";
        messageBox.componentInstance.message = 'Equipo creado';
      }
      else{
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operacion";
        messageBox.componentInstance.message = 'Error al registrar equipo';
      }
    });

  }

}