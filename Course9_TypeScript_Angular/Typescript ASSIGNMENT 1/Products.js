var Products = /** @class */ (function () {
    function Products(productId, ProductName, UnitPrice, Qty) {
        if (productId === void 0) { productId = 0; }
        if (ProductName === void 0) { ProductName = ""; }
        if (UnitPrice === void 0) { UnitPrice = 0; }
        if (Qty === void 0) { Qty = 0; }
        this.ProductId = productId;
        this.ProductName = ProductName;
        this.UnitPrice = UnitPrice;
        this.Qty = Qty;
    }
    Products.prototype.getTotal = function () {
        return this.UnitPrice * this.Qty;
    };
    Products.prototype.showDetails = function () {
        console.log("Product ID : ".concat(this.ProductId, " \n             Product Name : ").concat(this.ProductName, " \n             Unit Price : ").concat(this.UnitPrice, " \n             Quantity : ").concat(this.Qty, "\n             -----------------------------\n             Total Price : ").concat(this.getTotal(), "\n             -----------------------------"));
    };
    return Products;
}());
var Product1 = new Products(1401, 'Bingo Chips', 10, 5);
var Product2 = new Products(1402, 'Adidas', 10000, 12);
var Product3 = new Products(1403, 'Oreo', 45, 40);
Product1.showDetails();
Product2.showDetails();
Product3.showDetails();
