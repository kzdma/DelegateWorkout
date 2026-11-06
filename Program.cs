
//Main method - Client(Console App) code
StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
stockExchangeMonitor.PriceChangeHandler = ShowPrice;

stockExchangeMonitor.Start();

static void ShowPrice(int price)
{
	Console.WriteLine($"New price is: {price}");
}



//Server code
public class StockExchangeMonitor
{
	public delegate void PriceChange(int price);
	public PriceChange PriceChangeHandler { get; set; }

	public void Start()
	{
		while (true)
		{
			int bankOfAmericaPrice = (new Random()).Next(100);
			PriceChangeHandler(bankOfAmericaPrice);
			Thread.Sleep(2000);
		}
	}
}







//Tirgul in Class ////////////////////////////
//Main method
//StringHelper helper = new StringHelper();
//Action<string> showMessage = Show;

//helper.Move(10, showMessage);

//CountDelegate d1 = helper.GetCount;
//CountDelegate d2 = helper.GetCountSymbolA;

//string testString = "Hello Aloha HOLA Shalom";
//Console.WriteLine("Characters count: {0}", TestDelegate(d1, testString));
//Console.WriteLine("Characters ‘A’ count: {0}", TestDelegate(d2, testString));

//static void Show(string message)
//{
//	Console.WriteLine(message);
//}

//static int TestDelegate(CountDelegate method, string testString)
//{
//	return method(testString);
//}


//// Invoke the delegates
//public delegate int CountDelegate(string message);
////public delegate void ShowMessage(string message);

//public class  StringHelper
//{
//	public int GetCount(string inputString)
//	{
//		return inputString.Length;
//	}

//	public int GetCountSymbolA(string inputString)
//	{
//		return inputString.Count(c => c == 'A');
//	}

//	public void Move(int distance, Action<string> method)
//	{
//		for (int i = 1; i <= distance; i++)
//		{
//			Thread.Sleep(1000);
//			method($"Moving in progress... covered distance: {i} km");
//		}
//	}
//}


