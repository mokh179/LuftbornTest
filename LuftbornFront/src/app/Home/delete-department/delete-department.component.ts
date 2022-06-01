import { Component, OnInit } from '@angular/core';
import { DepartmentServiceService } from 'src/app/Services/department-service.service';
import { Department } from 'src/app/VModels/department';
import { ActivatedRoute,Router } from '@angular/router';
@Component({
  selector: 'app-delete-department',
  templateUrl: './delete-department.component.html',
  styleUrls: ['./delete-department.component.css']
})
export class DeleteDepartmentComponent implements OnInit {

  constructor(private DeptSer:DepartmentServiceService,private ac:ActivatedRoute,private router:Router) { }
  Dept:Department=new Department();

  ngOnInit(): void {
    this.ac.params.subscribe(i=>{
      this.DeptSer.getbyID(i.id).subscribe(a=>{
        this.Dept=a;
      })
    })
  }
  
  delete(){
    this.DeptSer.deleteDepartment(this.Dept).subscribe(
      a=>{this.router.navigateByUrl('/Departments')}
    );
  }

}
