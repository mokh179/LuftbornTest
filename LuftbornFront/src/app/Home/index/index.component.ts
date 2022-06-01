import { Component, OnInit } from '@angular/core';
import { DepartmentServiceService } from 'src/app/Services/department-service.service';
import { Department } from 'src/app/VModels/department';
@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  constructor(private DepService:DepartmentServiceService) { }
   Departments:Department[]=[]
  ngOnInit(): void {
    this.DepService.GetAll().subscribe(a=>
      {
        this.Departments=a
        console.log(this.Departments)
      }
      )
  }

  GetByID(id:number){

  }

}
