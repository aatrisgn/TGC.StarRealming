import { Component, OnInit, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MsalService } from '@azure/msal-angular';
import { AccountInfo } from '@azure/msal-browser';

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.scss',
})
export class ProfileComponent implements OnInit {
  account = signal<AccountInfo | null>(null);

  constructor(private msalService: MsalService) {}

  ngOnInit(): void {
    this.account.set(this.msalService.instance.getActiveAccount());
  }
}
