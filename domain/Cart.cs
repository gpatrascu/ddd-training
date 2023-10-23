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

    public Product(string productName)
    {
        _productName = productName;
    }
}
