using System;
using System.Collections.Generic;

class Program
{

	
	static void Main(string[] args){
		List<int>numeros = new List<int>{10,20,30,40,50,60,70,80,90,100};
		
		int maior = numeros[0];
		
		
		foreach (int numero in numeros ) {
			if (numero > maior) {	
				maior = numero;	
			}
		}
		
	Console.WriteLine("O maior número da lista é: "+ maior);
		
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
