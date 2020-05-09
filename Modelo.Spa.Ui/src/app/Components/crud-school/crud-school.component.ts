import { Component, OnInit } from '@angular/core';

declare var $: any;

@Component({
  selector: 'app-crud-school',
  templateUrl: './crud-school.component.html',
  styleUrls: ['./crud-school.component.scss']
})
export class CrudSchoolComponent implements OnInit {

  listSchools: any[];
  showModalCreate = false;

  constructor()
  {

  }

  ngOnInit()
  {

  }

  ShowModalCreate()
  {
    $("#addEmployeeModal").removeClass('Hide')
    this.showModalCreate = true;
  }

}
