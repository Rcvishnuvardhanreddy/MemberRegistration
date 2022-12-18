import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { MemberService } from '../service/members.service.';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  showdonors: boolean = false;
  showtopdonors: boolean = false;
  showlocation: boolean = false;
  allMembers: Array<any> = [];
  topdonorarray: Array<any> = [];
  email: string = '';
  memberForm: FormGroup = new FormGroup({});
  isUpdateEnbled = false;
  selectRowId: any;
  selectedMemberData: any;
  displayStyle = "none";

  constructor(public memberService: MemberService,
    private router: Router,
    private fb: FormBuilder) { }

  ngOnInit(): void {
    //sessionStorage.setItem('status', 'on_page');

    //taking email from local storage and set in session storage
    //sessionStorage.setItem('email', window.localStorage.getItem('email'));

    this.getallMembers();
    //this.email = sessionStorage.getItem('email');
  }

  getallMembers() {
    this.showdonors = true;
    this.memberService.getAllMembers().subscribe((res: any) => {
      this.allMembers = res;
    });
  }

  setSelectRow(row: any) {
    this.selectRowId = row.id;
  }

  updateMemberRequest() {
    var selctedMember = this.allMembers.find(rec => rec.id == this.selectRowId);
    if (selctedMember != null) {
      //this.buildMemberForm(selctedMember);
      //this.isUpdateEnbled = true;
      this.selectedMemberData = selctedMember;
    }
  }

  onUpdateMemberDetails(updatedData: any) {
    this.isUpdateEnbled = false;
    let index = this.allMembers.findIndex(rec => rec.id == updatedData.id);
    this.allMembers[index] = updatedData;
    this.selectedMemberData = null;
  }

  deleteMember() {
    if (this.selectRowId) {
      var selctedMember = this.allMembers.find(rec => rec.id == this.selectRowId);
      if (confirm(`Are you sure to delete ${selctedMember.firstName + ' ' + selctedMember.lastName}`)) {
        this.memberService.deleteMembers(this.selectRowId).subscribe(data => {
          if (data) {
            this.allMembers = this.allMembers.filter(rec => rec.id !== this.selectRowId);
            this.selectRowId = null;
          }
        });
      }
    }
  }

  //for Logout
  Logout() {
    sessionStorage.setItem('logout', 'yes')
    this.router.navigate(['home'])
  }
}
