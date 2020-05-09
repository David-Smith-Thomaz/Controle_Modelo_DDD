import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  title = 'Modelo';
  showListSchool = false;  

  constructor() { }

  ngOnInit(): void {

  }

  onClickButtonShowListSchool()
  {
    this.showListSchool = true;
  }

  onClickButtonHideListSchool()
  {
  this.showListSchool = false;
  }
}
