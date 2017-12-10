import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductListComponent } from './product-list/product-list.component';
import { ShopRoutingModule } from './shop-routing.module';

@NgModule({
  imports: [
    CommonModule,
    ShopRoutingModule
  ],
  declarations: [
    ProductListComponent
  ]
})
export class ShopModule { }