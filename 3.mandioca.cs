using System;
class mandioca {
	static void Main() {
		int mandiocaTotal = 0;

		mandiocaTotal += Convert.ToInt32(Console.ReadLine()) * 300;
		mandiocaTotal += Convert.ToInt32(Console.ReadLine()) * 1500;
		mandiocaTotal += Convert.ToInt32(Console.ReadLine()) * 600;
		mandiocaTotal += Convert.ToInt32(Console.ReadLine()) * 1000;
		mandiocaTotal += Convert.ToInt32(Console.ReadLine()) * 150;
		mandiocaTotal += 225;
		Console.WriteLine(mandiocaTotal);
	}
}