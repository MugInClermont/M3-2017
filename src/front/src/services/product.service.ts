import { Injectable } from '@angular/core';
import { HttpClient, } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { ProductModel } from '../models/product.model';
import { environment } from '../environments/environment';
import { IProductService } from './iproduct.service';

@Injectable()
export class ProductService implements IProductService {

    constructor(private http: HttpClient) { }
    
    get(): Observable<ProductModel[]> {
        return this.http.get<ProductModel[]>(environment.api.products.all);
    }
}