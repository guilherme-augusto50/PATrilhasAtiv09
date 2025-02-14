using System;
using System.Collections.Generic;
class ContaBancaria
{
    public int numero {get; private set;}
    public string titular{get; private set;}
    public decimal saldo {get; private set;}
    public bool ativa {get; private set; }


    public ContaBancaria(int num, string tit){
    numero = num;
    titular = tit;
    saldo = 0; 
    ativa = true;
 }
    public void Depositar(decimal valor){
        if (valor > 0){
            saldo += valor;
            Console.WriteLine("Deposito do valor de {0:C} realizado com sucesso. Novo saldo de: {1:C}",valor,saldo );
        }else{
            Console.WriteLine("O valor deve ser positivo.");
        }
    }
    public bool Sacar(decimal valor){
        if (valor > 0 && valor <= saldo){
            saldo -= valor;
            Console.WriteLine("Saque no valor de {0:C} Realizado com sucesso. Novo saldo de: {1:C}", valor, saldo);
            return true;
        }
        Console.WriteLine("Saque nao permitido. Verifique o valor do saque. ");
        return false;
    }
    public void fecharConta(){
        if (saldo == 0 ){
            ativa = false;
            Console.WriteLine("Conta fechada com sucesso.");
        }else{
            Console.WriteLine("A conta só pode ser fechada se o saldo for zero.");
        }
    }
}
class Banco{
    private List<ContaBancaria> contas  = new List<ContaBancaria>();
    private int proximoNum = 1;

    public ContaBancaria AbrirConta(string titular){
        var conta = new ContaBancaria(proximoNum++, titular);
        contas.Add(conta);
        Console.WriteLine("Conta {0} aberta para {1}",conta,conta.titular);
        return conta;
    }
    public void fecharConta(int numConta){
        var conta = contas.Find(c => c.numero == numConta);
        if (conta != null){
            conta.fecharConta();
            if (!conta.ativa){
                    contas.Remove(conta);
            }
        }else {
            Console.WriteLine("Conta nao encontrada.");
        }
    }
}


class Program
{
    static void Main()
    {
        Banco banco = new Banco();

        Console.Write("Digite o nome do titular da primeira conta: ");
        string titular1 = Console.ReadLine();
        ContaBancaria conta1 = banco.AbrirConta(titular1);

        Console.Write("Digite o nome do titular da segunda conta: ");
        string titular2 = Console.ReadLine();
        ContaBancaria conta2 = banco.AbrirConta(titular2);

        conta1.Depositar(500);
        conta1.Sacar(200);

        conta2.Depositar(1000);
        conta2.Sacar(500);

        
        banco.fecharConta(conta1.numero);

        
        conta1.Sacar(300);
        banco.fecharConta(conta1.numero);

        Console.WriteLine("Operações finalizadas.");

        Console.WriteLine("\nPressione algo para sair . . . ");
        Console.ReadKey(true);
    }
}
