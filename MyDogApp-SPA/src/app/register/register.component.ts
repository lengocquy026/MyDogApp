import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyjsService } from '../_services/alertifyjs.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};

  constructor(private authService: AuthService,
              private alertify: AlertifyjsService) { }

  ngOnInit(): void {
  }

  register() {
    this.authService.register(this.model).subscribe(() => {
      this.alertify.success('registration successful');
    }, error => {
      this.alertify.error(error);
    });
  }

  cancel() {
    this.alertify.message('canceled');
  }
}
