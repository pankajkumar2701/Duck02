import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { TokenService } from '../angular-app-services/token.service';
import { TooltipService } from '../angular-app-services/tooltip.service';
import { User } from '../auth/user';

@Component({
  selector: 'app-logout',
  standalone: true,
  imports: [],
  templateUrl: './logout.component.html',
  styleUrl: './logout.component.scss'
})
export class LogoutComponent {
  user!: User;
  constructor(
    private router: Router,
    private tokenService: TokenService,
    private tooltipService: TooltipService
  ) {
  }
  ngOnInit(): void {
    this.populateUserProfile();
  }

  logout(): void {
    this.tokenService.logout();
    this.router.navigate(['/']);
  }

  isTooltipDisabled(element: HTMLElement): boolean {
    return this.tooltipService.isTooltipDisabled(element);
  }

  private populateUserProfile(): void {
    this.user = this.tokenService.getUserDetails();
  }
}
