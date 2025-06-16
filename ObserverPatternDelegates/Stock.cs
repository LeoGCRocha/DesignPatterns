namespace ObserverPatternDelegates;

public class Stock
{
    public Stock(string product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    private string Product { get; set; }
    private int Quantity { get; set; }

    // Define a signature to observer methods
    public delegate void LowStockHandler(string product, int quantity);

    // Subject or publisher
    public event LowStockHandler StockHandler;

    public void RemoveProduct(int quantity)
    {
        Quantity -= quantity;
        Console.WriteLine($"Remove {quantity} from {Product}. Have {Quantity}");

        // When invoker is called all methods "watching" this will be invoked.
        if (Quantity <= 5)
            StockHandler.Invoke(Product, Quantity);
    }
}