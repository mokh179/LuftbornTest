import { Component, OnInit } from '@angular/core';
import { DepartmentServiceService } from 'src/app/Services/department-service.service';
import { Department } from 'src/app/VModels/department';
import { ActivatedRoute,Router } from '@angular/router';

@Component({
  selector: 'app-edit-department',
  templateUrl: './edit-department.component.html',
  styleUrls: ['./edit-department.component.css']
})
export class EditDepartmentComponent implements OnInit {

  constructor(private DeptSer:DepartmentServiceService,private ac:ActivatedRoute,private ro:Router) { }
  Dept:Department=new Department();

  ngOnInit(): void {
    this.ac.params.subscribe(i=>{
      this.DeptSer.getbyID(i.id).subscribe(a=>{
        this.Dept=a;
      })
    })
  }

  Save(){
    this.DeptSer.edit(this.Dept).subscribe(a=>{this.ro.navigateByUrl('/department')});
    }

}
