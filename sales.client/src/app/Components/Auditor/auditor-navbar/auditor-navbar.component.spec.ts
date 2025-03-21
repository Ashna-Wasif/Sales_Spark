import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AuditorNavbarComponent } from './auditor-navbar.component';

describe('AuditorNavbarComponent', () => {
  let component: AuditorNavbarComponent;
  let fixture: ComponentFixture<AuditorNavbarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AuditorNavbarComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AuditorNavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
