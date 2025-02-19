using System;
using System.Collections.Generic;
using System.Linq;

namespace ddwdwdw
{
	class Carrinho {
		readonly List<Tuple<int, int>> produtos = new List<Tuple<int, int>>();
		
		public void AdicionarProduto(int preco, int qnt) {
			produtos.Add(new Tuple<int, int>(preco, qnt));
		}
		
		public void ListaProdutos() {
			foreach (var produto in produtos) {
				Console.WriteLine("{0} - {1}", produto.Item1, produto.Item2);
			}
		}
		
		public int CalcularValorTotal() {
			int sum = 0;
			foreach (var produto in produtos) {
				sum += produto.Item1 * produto.Item2;
			}
			
			return sum;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var carrinho = new Carrinho();
			
			carrinho.AdicionarProduto(50, 2);
			
			carrinho.ListaProdutos();
			
			Console.WriteLine(carrinho.CalcularValorTotal());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
