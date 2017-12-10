import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HttpModule } from "@angular/http";

import { AppRoutingModule } from './app-routing.component';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ShopModule } from './shop/shop.module';

import { ProductService } from '../services/product.service';
import { ProductMockService } from '../services/product.mock.service';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
  ],
  imports: [
    RouterModule,
    BrowserModule,
    HttpModule,
    ShopModule,
    AppRoutingModule
  ],
  providers: [
    { provide: 'IProductService', useClass: ProductMockService }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
