using ObserverPattern.Interfaces;

namespace ObserverPattern;

public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers = [];

    private float _temperature;

    public float Temperature
    {
        get => _temperature;
        set
        {
            _temperature = value; 
            NotifyAll();
        }
    }

    public void Attach(IObserver observer) => _observers.Add(observer);

    public void Detach(IObserver observer) => _observers.Remove(observer);

    public void NotifyAll()
    {
        foreach (var observer in _observers)
            observer.Update(this);
    }
}