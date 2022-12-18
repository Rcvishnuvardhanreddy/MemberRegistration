import { Component } from '@angular/core';

@Component({
  selector: 'app-member-registration',
  templateUrl: './member-registration.component.html'
})
export class MembersRegistrationComponent {
  canAddRegistration = false;
  selectedMemberData = null;
  previosulyAddedMemberData: any;

  addNewRegistration() {
    this.previosulyAddedMemberData = null;
    this.canAddRegistration = true;
  }

  onUpdateMemberDetails(data: any) {
    this.previosulyAddedMemberData = data;
    this.canAddRegistration = false;
  }
}
