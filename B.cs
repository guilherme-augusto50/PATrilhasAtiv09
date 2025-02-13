using System;
using System.Collections.Generic;

class Program
{

	
	static void Main(string[] args){
		List <string> palavras = new List<string> {"João", "", "Caio", "", "Guilherme",""};
		
		foreach (string pala in palavras ) {
			Console.WriteLine(pala);
		}
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
