/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { NumberOfEmploymentsChartComponent } from './numberOfEmployments-chart.component';

describe('NumberOfEmploymentsChartComponent', () => {
  let component: NumberOfEmploymentsChartComponent;
  let fixture: ComponentFixture<NumberOfEmploymentsChartComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NumberOfEmploymentsChartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NumberOfEmploymentsChartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
