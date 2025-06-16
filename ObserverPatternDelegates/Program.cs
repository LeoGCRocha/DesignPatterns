using ObserverPatternDelegates;

var stock = new Stock("Iphone 15", 10);
var emailNotifier = new EmailNotifierObserver();
var loggerNotifier = new LoggerObserver();

stock.StockHandler += emailNotifier.NotifyProductQuantity;
stock.StockHandler += loggerNotifier.LogProductQuantity;

stock.RemoveProduct(6);