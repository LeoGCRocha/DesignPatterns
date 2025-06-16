namespace ObserverPatternDelegates;

public class EmailNotifierObserver
{
    private const string BaseEmail = "leogcrocha@gmail.com";

    public void NotifyProductQuantity(string product, int quantity)
    {
        Console.WriteLine($"An email was sent to {BaseEmail}, product: {product} have only {quantity} itens.");
    }
}