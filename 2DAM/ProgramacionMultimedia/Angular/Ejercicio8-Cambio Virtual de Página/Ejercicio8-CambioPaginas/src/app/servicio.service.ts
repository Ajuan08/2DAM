import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServicioService {

  private isLoggedIn = false;
  private username = '';

  login(username: string): void {
    this.isLoggedIn = true;
    this.username = username;
  }

  isLoggedInUser(): boolean {
    return this.isLoggedIn;
  }

  getUsername(): string {
    return this.username;
  }
}
