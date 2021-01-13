using System;
class dividindo {
	static void Main() {
		int qtdNumeros, x, y, i;
		string[] numerosTemp;
		string divisao;
		float divisaoTemp;

		qtdNumeros = Convert.ToInt32(Console.ReadLine());

		for (i = 0; i < qtdNumeros; i++) {
			numerosTemp = Console.ReadLine().Split();

			x = Convert.ToInt32(numerosTemp[0]);
			y = Convert.ToInt32(numerosTemp[1]);

			if (y == 0) {
				Console.WriteLine("divisao impossivel");
			}
			else {
				divisaoTemp = (float)x / (float)y;
				divisao = divisaoTemp.ToString("0.0");
				Console.WriteLine(divisao);
			}
		}
	}
}