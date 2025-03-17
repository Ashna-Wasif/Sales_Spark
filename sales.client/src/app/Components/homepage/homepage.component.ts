import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-homepage',
  standalone: false,
  templateUrl: './homepage.component.html',
  styleUrl: './homepage.component.css'
})
export class HomepageComponent {
  showSearchBar: boolean = false;
  products: any[] = [];

  showSeachBarFtn() {

    if (this.showSearchBar == true) {
      this.showSearchBar = false;
    }
    else
      this.showSearchBar = true;

  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.fetchProducts(); // Fetch products when the component initializes
  }

  fetchProducts(): void {
    this.http.get<any[]>('https://localhost:7170/api/products/FetchProducts').subscribe(
      (data: any[]) => {
        this.products = data; // Assign fetched data to the products array
      },
      (error) => {
        console.error('Error fetching products:', error);
      }
    );
  }
}
