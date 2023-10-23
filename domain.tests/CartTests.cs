namespace domain.tests;

public class CartTests
{
    [Fact]
    public void Test1()
    {
        var cart = new Cart();
        
        cart.Add(new Product("Apple Pencil"));
        
        Assert.Equal(1, cart.Products.Count);
    }
}