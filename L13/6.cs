using System;
using System.Collections.Generic;
using System.Linq;

namespace ddwdwdw
{
	class Retangulo {
		readonly Tuple<int, int> tamanhos;
		
		public Retangulo(int x, int y) {
			this.tamanhos = new Tuple<int, int>(x, y);
		}
		
		public int area() {
			return tamanhos.Item1 * tamanhos.Item2;
		}
		
		public int perimetro() {
			return tamanhos.Item1 * 2 + tamanhos.Item2 * 2;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var rect = new Retangulo(10, 20);
			
			Console.WriteLine(rect.perimetro());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
