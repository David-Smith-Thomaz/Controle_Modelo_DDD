import { Component, OnInit, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';

declare var $: any;

@Component({
  selector: 'app-crud-school',
  templateUrl: './crud-school.component.html',
  styleUrls: ['./crud-school.component.scss']
})
export class CrudSchoolComponent implements OnInit {

  listSchools: any[];
  showModalCreate = false;

  @ViewChild('createModal') private createModal: ModalDirective
  @ViewChild('deleteModal') private deleteModal: ModalDirective
  @ViewChild('editModal') private editModal: ModalDirective

  constructor()
  {

  }

  ngOnInit()
  {

  }

  ShowModalCreate()
  {
    this.showModalCreate = true;
    setTimeout(() => {
      this.createModal.show();
    }, 500)
  }

}
