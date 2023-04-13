import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdicionarVacinasComponent } from './adicionar-vacinas.component';

describe('AdicionarVacinasComponent', () => {
  let component: AdicionarVacinasComponent;
  let fixture: ComponentFixture<AdicionarVacinasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdicionarVacinasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdicionarVacinasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
