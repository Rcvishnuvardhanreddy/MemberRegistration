import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  baseApiUrl = 'https://localhost:7297/'

  constructor(private http: HttpClient) { }
  private receiversigninURL = `${this.baseApiUrl}Users`;

  //to get all receivers
  getuser(userLoginData: any) {
    return this.http.post(`${this.receiversigninURL}/signIn`, userLoginData);
  }
}
