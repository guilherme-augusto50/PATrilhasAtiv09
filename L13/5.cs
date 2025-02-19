using System;
using System.Collections.Generic;
using System.Linq;

namespace ddwdwdw
{
	class Livro {
		bool estaDisponivel = true;
		
		public bool realizarEmprestimo() {
			if (estaDisponivel) {
				estaDisponivel = false;
				return false;
			}
			
			return true;
			
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var livro = new Livro();
			
			livro.realizarEmprestimo();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
