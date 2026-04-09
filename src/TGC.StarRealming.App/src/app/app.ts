import { CommonModule } from '@angular/common';
import { Component, OnDestroy, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { IconsModule } from './modules/icons.module';
import { MenuItem } from 'primeng/api';
import { MsalBroadcastService, MsalService } from '@azure/msal-angular';
import { InteractionStatus } from '@azure/msal-browser';
import { filter, Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CommonModule, IconsModule],
  templateUrl: './app.html',
  styleUrl: './app.scss',
  standalone: true,
})
export class App implements OnInit, OnDestroy {
  protected readonly title = signal('TGC.StarRealming.App');
  isLoggedIn = signal(false);

  private readonly destroying$ = new Subject<void>();

  items: MenuItem[] = [
    { label: 'Home', routerLink: '/' },
    { label: 'Profile', routerLink: '/profile' },
  ];

  constructor(
    private msalService: MsalService,
    private msalBroadcastService: MsalBroadcastService,
  ) {}

  ngOnInit(): void {
    this.msalService.handleRedirectObservable().subscribe();

    this.msalBroadcastService.inProgress$
      .pipe(
        filter((status) => status === InteractionStatus.None),
        takeUntil(this.destroying$),
      )
      .subscribe(() => {
        this.isLoggedIn.set(this.msalService.instance.getAllAccounts().length > 0);
        this.setActiveAccount();
      });
  }

  login(): void {
    this.msalService.loginRedirect();
  }

  logout(): void {
    this.msalService.logoutRedirect();
  }

  private setActiveAccount(): void {
    if (
      !this.msalService.instance.getActiveAccount() &&
      this.msalService.instance.getAllAccounts().length > 0
    ) {
      this.msalService.instance.setActiveAccount(
        this.msalService.instance.getAllAccounts()[0],
      );
    }
  }

  ngOnDestroy(): void {
    this.destroying$.next();
    this.destroying$.complete();
  }
}
