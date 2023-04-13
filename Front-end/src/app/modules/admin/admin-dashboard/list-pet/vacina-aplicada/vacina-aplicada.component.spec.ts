import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VacinaAplicadaComponent } from './vacina-aplicada.component';

describe('VacinaAplicadaComponent', () => {
  let component: VacinaAplicadaComponent;
  let fixture: ComponentFixture<VacinaAplicadaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VacinaAplicadaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VacinaAplicadaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
