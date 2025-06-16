namespace ObserverPatternDelegates;

public class LoggerObserver
{
    public void LogProductQuantity(string product, int quantity)
    {
        Console.WriteLine($"{product}#{quantity}");
    }
}