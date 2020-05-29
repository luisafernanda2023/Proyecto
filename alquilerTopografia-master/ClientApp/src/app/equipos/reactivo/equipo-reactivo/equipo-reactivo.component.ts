import { Component, OnInit } from '@angular/core';
import { Equipo } from '../../models/equipo';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EquipoService } from 'src/app/services/equipo/equipo.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/modal/alert-modal/alert-modal.component';

@Component({
  selector: 'app-equipo-reactivo',
  templateUrl: './equipo-reactivo.component.html',
  styleUrls: ['./equipo-reactivo.component.css']
})
export class EquipoReactivoComponent implements OnInit {

  equipo: Equipo;
  formGroup: FormGroup;
  submitted = false;

  constructor(private equipoService: EquipoService,
    private formBuilder: FormBuilder,
    private modalService: NgbModal) { }

  ngOnInit() {
    this.buildForm();
  }

  private buildForm() {
    this.equipo = new Equipo();
    let myDate = new Date();
    this.equipo.idEquipo = '';
    this.equipo.nEquipo = '';
    this.equipo.marca = '';
    this.equipo.tiempoAlquiler = myDate;
    this.equipo.valor = 0;

    this.formGroup = this.formBuilder.group({
      idEquipo: [this.equipo.idEquipo, Validators.required],
      nEquipo: [this.equipo.nEquipo, Validators.required],
      marca: [this.equipo.marca, Validators.required],
      tiempoAlquiler: [this.equipo.tiempoAlquiler, Validators.required],
      valor: [this.equipo.valor, Validators.required]

    });
  }

  get control() {
    return this.formGroup.controls;
  }

  onSubmit() {
    this.submitted = true;
    // stop here if form is invalid
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }

  add() {
    this.equipo = this.formGroup.value;
    this.equipoService.post(this.equipo).subscribe(p => {
      if (p != null) {

        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operación";
        messageBox.componentInstance.message = 'Equipo creado';

        this.equipo = p;
      }
    });

  }
}