using System;
using System.Collections.Generic;
using System.Linq;

namespace ddwdwdw
{
	class Aluno {
		public readonly string nome;
		
		List<int> notas = new List<int>();
		
		public Aluno(string nome) {
			this.nome = nome;
		}
		
		public void adicionarNota(int nota) {
			notas.Add(nota);
		}
		
		public int calcularMedia() {
			return notas.Sum() / notas.Count;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var aluno = new Aluno("Guilherme Augusto Alves Filomeno");
			
			aluno.adicionarNota(10);
			aluno.adicionarNota(20);
			
			Console.WriteLine(aluno.calcularMedia());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
