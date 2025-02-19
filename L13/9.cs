using System;
using System.Collections.Generic;
using System.Linq;

namespace ddwdwdw
{
	class Agenda {
		readonly HashSet<string> contatos = new HashSet<string>();
		
		public void AdicionarContato(string nome) {
			contatos.Add(nome);
		}
		
		public void RemoverContato(string nome) {
			contatos.Remove(nome);
		}
		
		public bool TemContato(string nome) {
			return contatos.Contains(nome);
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var contatos = new Agenda();
			
			contatos.AdicionarContato("Guilherme");
			
			Console.WriteLine(contatos.TemContato("Guilherme"));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
