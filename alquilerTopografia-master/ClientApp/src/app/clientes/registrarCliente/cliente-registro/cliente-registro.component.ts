import { Component, OnInit } from '@angular/core';
import { Cliente } from '../../models/cliente';
import { ClienteService } from 'src/app/services/cliente.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AlertModalComponent } from 'src/app/@base/modal/alert-modal/alert-modal.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-cliente-registro',
  templateUrl: './cliente-registro.component.html',
  styleUrls: ['./cliente-registro.component.css']
})
export class ClienteRegistroComponent implements OnInit {

  formGroup: FormGroup;
  cliente: Cliente;
  

  constructor(private clienteService: ClienteService, private formBuilder: FormBuilder, private modalService :NgbModal) { }

  ngOnInit() {
    this.buildForm();
  }

  private buildForm() {

    this.cliente = new Cliente();
    this.cliente.tipoId = '';
    this.cliente.idCliente = 0;
    this.cliente.nCliente = '';
    this.cliente.telefono = 0;
    this.cliente.direccion = '';
    this.formGroup = this.formBuilder.group({
      tipoId: [this.cliente.tipoId, Validators.required],
      idCliente: [this.cliente.idCliente, Validators.required],
      nCliente: [this.cliente.nCliente, Validators.required],
      telefono: [this.cliente.telefono, [Validators.required]],
      direccion: [this.cliente.direccion, [Validators.required]]
    });

  }

  get control() {
    return this.formGroup.controls;
  }

  onSubmit() {
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }

  add() {
    this.cliente = this.formGroup.value;
    this.clienteService.post(this.cliente).subscribe(c => {
      if (c != null) {
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operacion";
        messageBox.componentInstance.message = 'Cliente creado!';
        this.cliente = c;
     //   alert('Cliente creado!');
      }
    });

  }

}
