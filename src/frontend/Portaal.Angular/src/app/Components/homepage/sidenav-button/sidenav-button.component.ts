import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidenav-button',
  templateUrl: './sidenav-button.component.html',
  styleUrls: ['./sidenav-button.component.scss']
})
export class SidenavButtonComponent {

  @Input() route: string = "/";
  @Input() label: string = "";

  constructor(public router: Router) {}

  clicked() {
    this.router.navigateByUrl(this.route);
  }

}
