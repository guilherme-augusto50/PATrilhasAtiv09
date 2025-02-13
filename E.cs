using System;
using System.Collections.Generic;

class Program
{

	
	static void Main(string[] args){
		List<int> numeros = new List<int>{1,5,10,15,20,25,30,35,40,45,50};
		
		int soma = 0;
		
		foreach (int num in numeros) {
			soma += num;
		}

		int media = soma / numeros.Count;
		
		
		Console.WriteLine("A media dos números é: "+ media );

		
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
