using System;

namespace ddwdwdw
{
	class Conta {
		readonly public string nome;
		
		int dinheiro = 0;
		bool contaAberta = true;
		
		public int quantia {
			get { return this.dinheiro; }
		}
		
		public Conta(string nome) {
			this.nome = nome;
		}
		
		public int depositar(int quantia) {
			if (!this.contaAberta) {
				return -1;
			}
			
			this.dinheiro += quantia;
			return this.dinheiro;
		}
		
		public int sacar(int quantia) {
			if (!this.contaAberta) {
				return -1;
			}
			
			this.dinheiro -= quantia;
			return this.dinheiro;
		}
		
		public void fecharConta() {
			this.contaAberta = false;
		}
		
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var conta = new Conta("Matheus Cristian Rocha Gomes");
			
			conta.depositar(1000);
			Console.WriteLine(conta.quantia);
			conta.fecharConta();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
