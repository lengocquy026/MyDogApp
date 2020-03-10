import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../_services/auth.service';
import { AlertifyjsService } from '../_services/alertifyjs.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(
      private authService: AuthService, 
      private router: Router,
      private alertify: AlertifyjsService
  ) {}
          
  canActivate(): boolean {
    if (this.authService.loggedIn()) {
      return true;
    }
    
    this.alertify.error('You shall not pass!!!');
    this.router.navigate(['/home']);
  }
}
