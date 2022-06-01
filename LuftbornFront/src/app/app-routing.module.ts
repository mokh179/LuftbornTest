import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {IndexComponent} from './Home/index/index.component';
import { AddDepartmentComponent } from './Home/add-department/add-department.component';
import { GetDeptDetailsComponent } from './Home/get-dept-details/get-dept-details.component';
import { EditDepartmentComponent } from './Home/edit-department/edit-department.component';
import { DeleteDepartmentComponent } from './Home/delete-department/delete-department.component';
const routes: Routes = [
  {path:"Departments",component:IndexComponent},
{path:"",redirectTo:"Departments",pathMatch:'full'},
{path:"Add",component:AddDepartmentComponent },
{path:"department/details/:id",component:GetDeptDetailsComponent},
{path:"department/edit/:id",component:EditDepartmentComponent},
{path:"department/Delete/:id",component:DeleteDepartmentComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
exports: [RouterModule]
})
export class AppRoutingModule { }
