import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import  {FormsModule} from '@angular/forms' ;

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { IndexComponent } from './Home/index/index.component';
import {HttpClientModule} from '@angular/common/http';
import { AddDepartmentComponent } from './Home/add-department/add-department.component';
import { GetDeptDetailsComponent } from './Home/get-dept-details/get-dept-details.component';
import { EditDepartmentComponent } from './Home/edit-department/edit-department.component';
import { DeleteDepartmentComponent } from './Home/delete-department/delete-department.component'
@NgModule({
  declarations: [
    AppComponent,
    IndexComponent,
    AddDepartmentComponent,
    GetDeptDetailsComponent,
    EditDepartmentComponent,
    DeleteDepartmentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
