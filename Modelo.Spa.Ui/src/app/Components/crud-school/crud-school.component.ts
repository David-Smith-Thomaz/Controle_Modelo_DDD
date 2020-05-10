import { Component, OnInit, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { CrudSchoolService } from './crud-school.service';

declare var $: any;

@Component({
  selector: 'app-crud-school',
  templateUrl: './crud-school.component.html',
  styleUrls: ['./crud-school.component.scss']
})
export class CrudSchoolComponent implements OnInit {

  list: any[];
  showModalCreate = false;

  @ViewChild('createModal') private createModal: ModalDirective
  @ViewChild('deleteModal') private deleteModal: ModalDirective
  @ViewChild('editModal') private editModal: ModalDirective

  constructor(private crudSchoolService: CrudSchoolService)
  {

  }

  ngOnInit()
  {
    this.listSchools();
  }

  listSchools()
  {
    this.crudSchoolService.listSchools().subscribe(result => {
      this.list = result;
      console.log("this.list", this.list)
    });
  }
}
