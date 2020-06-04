import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MarcaService } from 'src/app/services/marca.service';
import { Marca } from 'src/app/clientes/models/marca';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-marca-modal',
  templateUrl: './marca-modal.component.html',
  styleUrls: ['./marca-modal.component.css']
})
export class MarcaModalComponent implements OnInit {

  _form:FormGroup;
  message:string="";
  view=false;

  constructor(private formBuilder:FormBuilder, private maService :MarcaService, public activeModal: NgbActiveModal) { }

  ngOnInit() {
    this._form = this.formBuilder.group({
      key:['',Validators.required]
    });
  }

  post(){
    if(this._form.invalid)
      return;

    var ma = new Marca();
    ma.nombre  = this._form.controls.key.value;
    this.view=true;

    this.maService.post(ma).subscribe(
      (data) => {
        if(data==null){
          this.message="Marca ya registrada";
        }
        else
          this.message = "Creado";
      },
      (error) => {
        this.message="Error en la petición";
      }
    );
  }


}
