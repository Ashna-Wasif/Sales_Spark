import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AuditorPageComponent } from './auditor-page.component';

describe('AuditorPageComponent', () => {
  let component: AuditorPageComponent;
  let fixture: ComponentFixture<AuditorPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AuditorPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AuditorPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
