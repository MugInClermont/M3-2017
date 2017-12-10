import { Component, OnInit, Inject } from '@angular/core';
import { IProductService } from '../../../services/iproduct.service';
import { ProductModel } from '../../../models/product.model';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  products: ProductModel[] = [];

  constructor(@Inject('IProductService') private productService: IProductService) { }

  ngOnInit() {
    this.productService.get().subscribe(res => {
      this.products = res;
    });
  }
}
