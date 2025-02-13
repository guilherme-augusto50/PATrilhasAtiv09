using System;


class Program
{
	class Calculadora {
	
		public double soma(double a, double b ){
			return a + b;
		}
		public double subtarir(double a, double b){
			return a - b;
		}
		public double mutiplicar(double a, double b){
			return a * b;
		}
		public double dividir(double a, double b){
			if (b == 0 ) {
				Console.WriteLine("Erro");
				return Double.NaN;
			}
			return a/b;
		}
	}

	
	static void Main(string[] args){
		Calculadora calc = new Calculadora();
		
		//double num1 = 10;
		//double num2 = 5; 
		
		Console.WriteLine("Escreva o primeiro número: ");
		double num1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Escreva o segundo número: ");
		double num2 = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Soma: " + calc.soma(num1, num2));
		Console.WriteLine("Subtraçao: " + calc.subtarir(num1,num2));
		Console.WriteLine("Multiplicaçao: "+ calc.mutiplicar(num1,num2));
		Console.WriteLine("Divisão "+ calc.dividir(num1,num2));
		
		

		
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
