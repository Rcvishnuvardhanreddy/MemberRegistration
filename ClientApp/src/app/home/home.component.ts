import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../service/user.service.';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  success: string = '';
  display: boolean = false;
  error: boolean = false;
  rsigninform: FormGroup = new FormGroup({});//to signin form
  errorMessage = ''

  constructor(
    private fb: FormBuilder,
    public userService: UserService,
    public router: Router) {
  }

  ngOnInit(): void {
    sessionStorage.setItem('status', 'signin');

    this.rsigninform = this.fb.group({
      email: ['', Validators.compose([Validators.required])],
      password: ['', Validators.required]
    });

  }

  navigateTo(isAdmin: boolean) {
    if (isAdmin) {
      this.router.navigate(['admin-home']);
    } else {
      this.router.navigate(['home']);
    }
  }

  checkData(rsigninform: any) {
    // console.log(rsigninform.value)
    this.display = true;
    this.errorMessage = '';
    this.userService.getuser(rsigninform.value).subscribe((res: any) => {
      if (res == null) {
        this.errorMessage = "Invalid Login Details!!!! Incorrect email or password";
      }
      else {
        this.navigateTo(res.isAdmin)
      } 
    }, (error: any) => {
      window.alert("Invalid Login Details!!!! Incorrect email or password");
    });
    this.display = false;
  }
}
