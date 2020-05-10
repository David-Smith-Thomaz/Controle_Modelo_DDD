import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CrudSchoolComponent } from './Components/crud-school/crud-school.component';
import { CrudSchoolService } from './Components/crud-school/crud-school.service';
import { HttpClientModule } from '@angular/common/http'

@NgModule({
  declarations: [
    AppComponent,
    CrudSchoolComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [CrudSchoolService],
  bootstrap: [AppComponent]
})
export class AppModule { }
