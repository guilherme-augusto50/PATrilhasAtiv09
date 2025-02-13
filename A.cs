using System;

class Program
{

	
	static void Main(string[] args){
		int[] numeros = {1,2,3,4,5,6,7,8,9,10};
		
		foreach (int num in numeros) {
			Console.WriteLine(num);
		}
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
