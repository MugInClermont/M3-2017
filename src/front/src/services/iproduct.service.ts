import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { ProductModel } from '../models/product.model';

export interface IProductService {
    get(): Observable<ProductModel[]>;
}