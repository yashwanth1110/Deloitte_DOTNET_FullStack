class Products {
    public ProductId: number;
    public ProductName: string;
    public UnitPrice: number;
    public Qty: number;


    constructor(productId: number = 0,ProductName: string = "", UnitPrice: number = 0, Qty: number = 0) {
        this.ProductId = productId;
        this.ProductName= ProductName;
        this.UnitPrice= UnitPrice;
        this.Qty= Qty;
 }

    public getTotal(): number {
        return this.UnitPrice * this.Qty;
    }

    
    public showDetails(): void {
        console.log(`Product ID : ${this.ProductId}`);
        console.log(`Product Name : ${this.ProductName}`);
        console.log(`Unit Price : ${this.UnitPrice}`);
        console.log(`Quantity : ${this.Qty}`);
        console.log('-----------------------------');
        console.log(`Total Price : ${this.getTotal()}`);
        console.log('-----------------------------');
    }
}
let Product1=new Products(1401,'Bingo Chips',10,5);
let Product2=new Products(1402,'Adidas',10000,12);
let Product3=new Products(1403,'Oreo',45,40);

Product1.showDetails();
Product2.showDetails();
Product3.showDetails();