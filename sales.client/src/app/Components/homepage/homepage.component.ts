import { Component } from '@angular/core';

@Component({
  selector: 'app-homepage',
  standalone: false,
  templateUrl: './homepage.component.html',
  styleUrl: './homepage.component.css'
})
export class HomepageComponent {
  showSearchBar: boolean = false;

  showSeachBarFtn() {
    
    if (this.showSearchBar == true) {
      this.showSearchBar = false;
    }
    else
      this.showSearchBar = true;

  }
}
