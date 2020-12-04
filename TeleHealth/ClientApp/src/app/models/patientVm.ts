import { last } from "rxjs/operators";

// interface PatientVm {
//   id: number;
//   firstname: string;
//   lastname: string;
//   gender: string;
//   createdDate: Date;
//   updatedDate: Date;
// }

export class PatientVm {
  public constructor(
  public id: number,
  public firstname: string,
  public lastname: string,
  public gender: string,
  public createdDate: Date,
  public updatedDate: Date,

  ) { }

  static fromJsonList(array): PatientVm[] {
      
      var patientVm = JSON.parse(array._body);

      return patientVm.map(json => PatientVm.fromJson(json))
  }

  static fromJsonToObject(object): PatientVm {
      return PatientVm.fromJson(JSON.parse(object._body));
  }

  static fromJson({ id, firstname, lastname, gender, createdDate, updatedDate }): PatientVm {
      return new PatientVm(
          id, firstname, lastname, gender, createdDate, updatedDate
      );
  }


}