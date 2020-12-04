import { Component, Inject, OnInit, OnDestroy } from '@angular/core';
import { HttpClient, HttpClientModule, HttpHeaders } from '@angular/common/http';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-patient',
  templateUrl: './add-patient.component.html'
})
export class AddPatientComponent implements OnInit, OnDestroy {
  public form: FormGroup;
  public baseUrl: string;
  public hasErrors: boolean;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private fb: FormBuilder, private router: Router) {
    this.baseUrl = baseUrl;
  }

  ngOnInit() {
    this.form = this.fb.group({
      Firstname: [null, Validators.required],
      Lastname: [null, Validators.required],
      Gender: ["", Validators.required],
    });
  }

  ngOnDestroy(): void { }

  public async onSubmit(value: any) {

    if (!this.form.valid) {
      this.hasErrors = true;
      return;
    }

    try {

      const model = {
        ...value,
      };

      const header = new HttpHeaders().set('Content-type', 'application/json');
      await this.http.post<any>(this.baseUrl + 'patient', model, { headers: header }).subscribe(response => {
        this.router.navigate(['/patient-list']);
      });
    } catch (error) {
      alert('An error occured when trying to add a new patient, please try again later.');
    }

  }

  public hasError(control: string, error: string) {
    return this.form.controls[control] && this.form.controls[control].hasError(error);
  }

}
