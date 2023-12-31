namespace domain.tests;

public class CartTests
{
    [Fact]
    public void AddingOneItem()
    {
        var cart = new Cart();
        
        cart.Add(new Product("Apple Pencil", "1111"));
        
        Assert.Equal(1, cart.Lines.Count);
    }
    
    [Fact]
    public void AddingTwoItems()
    {
        var cart = new Cart();
        
        cart.Add(new Product("Apple Pencil", "1111"));
        cart.Add(new Product("Sony Wireless headphone", "2222"));
        
        Assert.Equal(2, cart.Lines.Count);
    }
    
    [Fact]
    public void AddingQuantity()
    {
        var cart = new Cart();
        
        cart.Add(new Product("Apple Pencil", "1111"), 2);
        
        Assert.Equal(1, cart.Lines.Count);
        Assert.Equal(2, cart.Lines[0].Quantity);
    }
}