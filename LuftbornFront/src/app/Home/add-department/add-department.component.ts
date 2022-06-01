import { Component, OnInit } from '@angular/core';
import { Department } from 'src/app/VModels/department';
import { DepartmentServiceService } from 'src/app/Services/department-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-department',
  templateUrl: './add-department.component.html',
  styleUrls: ['./add-department.component.css']
})
export class AddDepartmentComponent implements OnInit {
   Dept:Department=new Department();

  show(data:any)
  {
   console.log(data)
  }

  Save(){
    this.Dept.creationDate=new Date();
    this.DepService.addDepartment(this.Dept).subscribe(a=>{this.router.navigateByUrl('/Departments')});
    console.log(this.Dept);
  }
  constructor(private DepService:DepartmentServiceService,private router:Router) { }

  ngOnInit(): void {
  }
}
