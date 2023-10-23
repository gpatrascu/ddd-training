namespace domain;
public class Cart
{
    private List<CartLine> lines = new List<CartLine>();
    
    public void Add(Product product, int quantity = 1)
    {
        this.lines.Add(new CartLine(product, quantity));
    }

    public IList<CartLine> Lines => lines.AsReadOnly();
}

public class CartLine
{
    public Product Product { get; }
    public int Quantity { get; }

    public CartLine(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}

public class Product
{
    private readonly string _productName;
    private readonly string _barcode;

    public Product(string productName, string barcode)
    {
        _productName = productName;
        _barcode = barcode;
    }
}
