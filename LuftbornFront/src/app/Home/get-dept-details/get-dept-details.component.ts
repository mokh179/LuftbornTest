import { Component, OnInit } from '@angular/core';
import { DepartmentServiceService } from 'src/app/Services/department-service.service';
import { Department } from 'src/app/VModels/department';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-get-dept-details',
  templateUrl: './get-dept-details.component.html',
  styleUrls: ['./get-dept-details.component.css']
})
export class GetDeptDetailsComponent implements OnInit {
 
  Dept:Department=new Department();

  constructor(private DeptSer:DepartmentServiceService,private ac:ActivatedRoute) { }

  ngOnInit(): void {
    this.ac.params.subscribe(i=>{
      this.DeptSer.getbyID(i.id).subscribe(a=>{
        this.Dept=a;
      })
    })
  }

}
