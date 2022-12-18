import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MemberService } from '../service/members.service.';

@Component({
  selector: 'app-add-update-member',
  templateUrl: './add-update-member.component.html'
})
export class AddUpdateMemberComponent implements OnInit {
  memberForm: FormGroup = new FormGroup({});
  @Input() memberData: any = null;
  @Output() onMemberDataUpdated = new EventEmitter<any>();
  displayStyle = "none";
  isUpdate = false;

  constructor(private fb: FormBuilder,
    private memberService: MemberService) {
  }

  ngOnInit(): void {
    this.buildMemberForm(this.memberData);
    this.isUpdate = this.memberData != null;
    this.openPopup();
  }

  buildMemberForm(data: any) {
    this.memberForm = this.fb.group({
      firstName: [(data?.firstName || ''), Validators.compose([Validators.required])],
      lastName: [(data?.lastName || ''), Validators.compose([Validators.required])],
      phone: [(data?.phone || ''), Validators.compose([Validators.required])],
      email: [(data?.email || ''), Validators.compose([Validators.required, Validators.email])],
      address: [(data?.address || '')]
    });
  }

  addOrUpdateDetails() {
    if (this.memberForm.valid) {
      if (this.isUpdate) {
        this.updateMemberDetails();
      } else {
        this.addMemberDetails();
      }
    }
  }

  addMemberDetails() {
    var memberData = this.memberForm.value;
    this.memberService.addMember(memberData).subscribe(data => {
      this.onMemberDataUpdated.emit(data);
      this.closePopup();
    });
  }

  updateMemberDetails() {
    var memberData = this.memberForm.value;
    memberData.id = this.memberData.id;
    this.memberService.updateMember(this.memberData.id, memberData).subscribe(data => {
      this.onMemberDataUpdated.emit(data);
      this.closePopup();
    });
  }

  openPopup() {
    this.displayStyle = "block";
  }
  closePopup() {
    this.displayStyle = "none";
  }
}
