import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import { ProductModel } from '../models/product.model';
import { IProductService } from './iproduct.service';

@Injectable()
export class ProductMockService implements IProductService {

    private products: ProductModel[] = [];

    constructor() { 

        this.products.push({id: 1, name: "Hand spinner de combat", description:"Silencieux, et surtout Fluorescent , aide a s’endormir après une longue journée de classe ou de reunion. Petit il se glisse dans votre poche, utilisez le partout, Metro, bus, taxi, fusée, avion de chasse...", image: "/assets/products/hand-spinner.jpg"});
        this.products.push({id: 1, name: "De la laine",  description:"Gros fil léger pour un tricot rapide et facile. Idéal pour débutants et débutantes. ce fil est doté d'un toucher soyeux, infeutrable. Rapido est un fil doux, chaud et volumineux. Hummm, on se sent bien dans son pull.", image: "/assets/products/laine.jpg" });
        this.products.push({id: 1, name: "Tire-bouchon classe",  description:" Outil pour déboucher une bouteille le vin. Il ouvre les bouteilles d'une simple pression sur un bouton avec classe. Permet une ouverture facilitée des bouteilles du vin tout en divertissant vos invitées.", image: "/assets/products/tire-bouchon.jpg" });
        this.products.push({id: 1, name: "Un repas pour 2",  description:"Mixer dans le robot : 80g de chien, 70g de poitrine, 60g de gras de lard, 1 échalote, 1 gousse d'ail, 4 ou 5 branches (ne prendre que les feuilles) de persil. Vider le hachis dans un grand saladier, saler, poivrer.", image: "/assets/products/chien.jpg" });
        this.products.push({id: 1, name: "Un convertisseur de bitcoin", description:"Cochon convertisseur de bitcoin. Insère une pièce, il te chie un faux diamant. Idéal pour les riches qui n'en ont rien à foutre. Existe également en version euros : convertie tous tes euros facilement.", image: "/assets/products/bitcoin.png" });
    }
    
    get(): Observable<ProductModel[]> {
        return Observable.of(this.products);
    }
}