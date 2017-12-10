import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductListComponent } from './product-list/product-list.component';

const shopRoutes: Routes = [
    { path: 'products', component: ProductListComponent, pathMatch: 'full' }
];

@NgModule({
    imports: [RouterModule.forChild(shopRoutes)],
    exports: [RouterModule]
})
export class ShopRoutingModule { }
    