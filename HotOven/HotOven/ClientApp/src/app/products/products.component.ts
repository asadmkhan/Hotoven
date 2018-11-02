import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {

  ngOnInit() {
  }

  public ProductsList: Products[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Products[]>(baseUrl + 'api/Products').subscribe(result => {
      this.ProductsList = result;
    }, error => console.error(error));
  }

}

interface Products {
  Id: number;
  ProductName: number;
  Price: number;
  Description: string;
  IsActive: boolean;

}
