import { CommonModule } from '@angular/common';
import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { IconsModule } from './modules/icons.module';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CommonModule, IconsModule],
  templateUrl: './app.html',
  styleUrl: './app.scss',
  standalone: true
})
export class App {

  protected readonly title = signal('TGC.StarRealming.App');

  items:MenuItem[] = [
    {
      label: 'Home',
      routerLink: '/'
    }
  ]
}
