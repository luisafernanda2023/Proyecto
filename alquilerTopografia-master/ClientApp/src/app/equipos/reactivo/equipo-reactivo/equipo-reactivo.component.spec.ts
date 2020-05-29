import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { EquipoReactivoComponent } from './equipo-reactivo.component';

describe('EquipoReactivoComponent', () => {
  let component: EquipoReactivoComponent;
  let fixture: ComponentFixture<EquipoReactivoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EquipoReactivoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EquipoReactivoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
