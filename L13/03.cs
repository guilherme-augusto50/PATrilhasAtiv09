using System;

class produto{
	public int qnt;
	public int preco;
	
	public produto (int qnt, int preco){
		this.qnt = qnt;
		this.preco = preco;
	}		
	
	public int calcular(){
		return this.qnt * this.preco;
	
	}
}
class Program
{
	static void Main(string[] args){
	
		var produto = new  produto(34, 25);
		
		Console.WriteLine(produto.calcular());
		
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
