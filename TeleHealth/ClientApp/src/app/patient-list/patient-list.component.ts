import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PatientVm } from '../models/patientVm';

@Component({
  selector: 'app-patient-list',
  templateUrl: './patient-list.component.html'
})
export class PatientListComponent {
  public patients: PatientVm[];


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<PatientVm[]>(baseUrl + 'patient').subscribe(result => {
      this.patients = result;
    }, error => console.error(error));
  }
}
