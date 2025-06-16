using ObserverPattern.Interfaces;

namespace ObserverPattern;

public abstract class NewsAgencies(string name) : IObserver
{
    private string Name { get; set; } = name;

    public void Update(ISubject subject)
    {
        if (subject is WeatherStation weatherStation)
            Console.WriteLine($"Temperature is {weatherStation.Temperature} news on {Name}");
    }
}