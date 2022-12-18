import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MemberService {
  baseApiUrl = 'https://localhost:7297/api/Members'

  constructor(private http: HttpClient,
  ) {
  }
  private receiversigninURL = `${this.baseApiUrl}`;

  //to get all receivers
  getAllMembers() {
    return this.http.get(`${this.baseApiUrl}/all`);
  }

  deleteMembers(memberId: number) {
    return this.http.delete(`${this.baseApiUrl}/${memberId}`);
  }

  addMember(memberDetails: any) {
    return this.http.post(`${this.baseApiUrl}`, memberDetails);
  }

  updateMember(memberId: number, memberDetails: any) {
    return this.http.put(`${this.baseApiUrl}/${memberId}`, memberDetails);
  }
}
