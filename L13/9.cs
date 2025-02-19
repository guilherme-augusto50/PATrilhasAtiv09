using System;

namespace ddwdwdw
{
	class Triangulo {
		int t1;
		int t2;
		int t3;
		public Triangulo(int t1, int t2, int t3) {
			this.t1 = t1;
			this.t2 = t2;
			this.t3 = t3;
		}
		
		public bool ehEquilatero() {
			return (this.t1 == this.t2) == (this.t1 == this.t3);
		}
		
		public bool ehIsoceles() {
			return this.t1 == this.t2 || this.t1 == this.t3 || this.t2 == this.t3;
		}
		
		public bool ehEscaleno() {
			return (this.t1 != this.t2) == (this.t1 != this.t3);
		}
		
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var t = new Triangulo(1, 3, 2);
			
			Console.WriteLine(t.ehIsoceles());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
