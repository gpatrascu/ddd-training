namespace domain;
public class Cart
{
    private List<Product> products = new List<Product>();
    
    public void Add(Product product)
    {
        this.Products.Add(product);
    }

    public IList<Product> Products => products.AsReadOnly();
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
