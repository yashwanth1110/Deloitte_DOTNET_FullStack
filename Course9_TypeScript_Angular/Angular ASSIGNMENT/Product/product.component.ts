import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  public pname:string = "";
  public unitprice:number = 0;
  public quantity:number = 0;
  public total:number = 0; 

  public getTotalButtonClick():void{
        this.total = this.unitprice * this.quantity;
  }

  public increment():void{
    this.quantity++;
  }
  public decrement():void{
    this.quantity--;
  }

}
