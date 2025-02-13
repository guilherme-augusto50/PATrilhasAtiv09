using System;
using System.Collections.Generic;

class Program
{

	
	static void Main(string[] args){
		List <string> palavras = new List<string> {"João", "", "Caio", "", "Guilherme",""};
		
		string longa = palavras[0];
	
		
		
		foreach (string palavra in palavras ) {
			if (palavra.Length > longa.Length) {	
				longa = palavra;
			}
		}
		
	Console.WriteLine("A palavra mais longa é: "+ long);
		
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
