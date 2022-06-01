import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Department } from '../VModels/department';
@Injectable({
  providedIn: 'root'
})
export class DepartmentServiceService {

  constructor(private http:HttpClient) { }
  GetAll(){
    return this.http.get<Department[]>('https://localhost:7210/api/Departments/AllDepartments');
  }

  addDepartment(dept:Department){
    return this.http.post("https://localhost:7210/api/Departments/AddDepartment",dept)
  }
getbyID(id:number){
  return this.http.get<Department>("https://localhost:7210/api/Departments/Department/"+id)
}
edit(dept:Department){
return this.http.put("https://localhost:7210/api/Departments/EditDepartment/",dept)
}
deleteDepartment(dept:Department){
  return this.http.post("https://localhost:7210/api/Departments/Remove",dept)

}
}
