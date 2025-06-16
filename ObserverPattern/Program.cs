using ObserverPattern;

WeatherStation weatherStation = new WeatherStation();
AgencyBrazil agBr = new AgencyBrazil();
AgencyMexico agMex = new AgencyMexico();
weatherStation.Attach(agBr);
weatherStation.Attach(agMex);

while (true)
{
    Console.WriteLine("Press c to continue, otherwise will stop.");
    var input = Console.ReadLine();
    if (input != "c") break;
    var randomTemperature = new Random().NextInt64(25, 35);
    weatherStation.Temperature = randomTemperature;
}