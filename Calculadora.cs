using System;
					
public class Program
{
	public static void Main()
	{
		//Calculadora
		int i = 0;

		while (i < 1)
		{
			Console.WriteLine(
				"1- Soma\n" +
				"2- Subtração\n" +
				"3- Multiplicação\n" +
				"4- Divisão\n" +
				"5- Resto da divisão\n" +
				"6- Potenciação\n"+
				"0- Parar\n" +
				"Escolha uma opcao de 1 a 6: ");
			int opcao = Convert.ToInt32(Console.ReadLine());
			if (opcao == 0){
			i++;
			break;
			}
		Console.WriteLine("Digite um valor: ");
		double num1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite o segundo valor:");
		double num2 = Convert.ToDouble(Console.ReadLine());


		switch (opcao)
		{
			case 1:
				Console.WriteLine($"A soma dos números {num1} e {num2} é: " + $"{num1 + num2}\n");
				break;
			case 2:
				Console.WriteLine($"A subtração dos números {num1} e {num2} é: " + $"{num1 - num2}\n");
				break;
			case 3:
				Console.WriteLine($"A multiplicação dos números {num1} e {num2} é: " + $"{num1 * num2}\n");
				break;
			case 4:
 				double divisor = num1/num2;
				if (divisor >= 0){
				Console.WriteLine("Não é possível dividir por zero.");
				} else{
				Console.WriteLine($"A divisão dos números {num1} e {num2} é: " + $"{divisor}\n");
				}
				break;
			case 5:
				Console.WriteLine($"O resto da divisão {num1} e {num2} é: " + $"{num1 % num2}\n");
				break;
			case 6:
				double potencia = Math.Pow(num1,num2);
				Console.WriteLine($"A potenciaação de {num1} e {num2} é: " + $"{potencia}\n");
				break;
		}
		}
		
		
	}
	
	
}
