using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo OOP");


            AnalistaDeTI analistaDeTI = new AnalistaDeTI();
            analistaDeTI.AdicionarNome("Elias", "Santos");

            analistaDeTI.AdicionarSalarioPadrao(10000);
            

            Console.WriteLine(analistaDeTI.Nome);
            Console.WriteLine(analistaDeTI.Salario);

            //ContaPoupanca contaPoupanca = new ContaPoupanca(111, 0);
            //contaPoupanca.Depositar(100);
            //contaPoupanca.Sacar(10);

            //double saldoPoupanca = contaPoupanca.ConsultarSaldoDisponivel();
            //Console.WriteLine("Saldo Conta Poupança: R$ {0}", saldoPoupanca);


            //ContaCorrente contaCorrente = new ContaCorrente(222, 100);
            //contaCorrente.Depositar(100);
            //contaCorrente.Sacar(10);

            //double saldoContaCorrente = contaCorrente.ConsultarSaldoDisponivel();
            //Console.WriteLine("Saldo Conta Poupança: R$ {0}", saldoContaCorrente);












            //AnalistaDeTI analistaDeTI = new AnalistaDeTI();
            //Gerente gerente = new Gerente();
            //GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
            //GerenteDeTI gerenteDeTI = new GerenteDeTI();


            //analistaDeTI.Nome = "Elias dos Santos";
            //analistaDeTI.Salario = 5000;

            //Console.WriteLine("Salário Analista de TI: R$ {0}", analistaDeTI.Salario);

            //analistaDeTI.ReajustarSalario();

            //Console.WriteLine("Salário Analista de TI REAJUSTADO: R$ {0}", analistaDeTI.Salario);

            //Console.WriteLine("_________________________________________________________________\n");

            //gerente.Nome = "João da Silva";
            //gerente.Salario = 8000;

            //Console.WriteLine("Salário Analista de TI: R$ {0}", gerente.Salario);

            //gerente.ReajustarSalario();

            //Console.WriteLine("Salário Analista de TI REAJUSTADO: R$ {0}", gerente.Salario);


            //Console.WriteLine("_________________________________________________________________\n");

            //gerenteDeAgencia.Nome = "Caio da Silva";
            //gerenteDeAgencia.Salario = 10000;

            //Console.WriteLine("Salário Analista de TI: R$ {0}", gerenteDeAgencia.Salario);

            //gerenteDeAgencia.ReajustarSalario();

            //Console.WriteLine("Salário Analista de TI REAJUSTADO: R$ {0}", gerenteDeAgencia.Salario);


            //Console.WriteLine("_________________________________________________________________\n");

            //gerenteDeTI.Nome = "Ricardo da Silva";
            //gerenteDeTI.Salario = 20000;

            //Console.WriteLine("Salário Analista de TI: R$ {0}", gerenteDeTI.Salario);

            //gerenteDeTI.ReajustarSalario();

            //Console.WriteLine("Salário Analista de TI REAJUSTADO: R$ {0}", gerenteDeTI.Salario);


            // ****************************


            //ContaPoupanca contaPoupanca1 = new ContaPoupanca(112, 0);
            //contaPoupanca1.Depositar(500);
            //contaPoupanca1.Sacar(10);
            //contaPoupanca1.MostrarNumeroDaConta();

            //double saldoContaPoupanca = contaPoupanca1.ConsultarSaldoDisponivel();
            //Console.WriteLine("Saldo Poupança: R$ {0}", saldoContaPoupanca);


            //Conta contaCorrente1 = new Conta(555, 200);

            //contaCorrente1.Depositar(300);
            //contaCorrente1.Sacar(100);

            //double saldoContaCorrente = contaCorrente1.ConsultarSaldoDisponivel();
            //Console.WriteLine("Saldo Corrente: R$ {0}", saldoContaCorrente);






            // ***************** Aula 06
            //Conta conta1 = new Conta(123, 500);
            //Conta conta2 = new Conta(456, 800);
            //Conta conta3 = new Conta(788, 900);
            //Conta conta4 = new Conta(101, 1000);


            //Console.WriteLine("Total de Contas Criadas: {0}", Conta.TotalContasCriadas);
            //Console.WriteLine("Próximo Total de Contas Criadas: {0}", Conta.ProximoTotalContasCriadas());


            // Aula 05

            // Criando um objeto de cada classe

            // CartaoDeCredito cartao1 = new CartaoDeCredito();
            // Cliente cliente1 = new Cliente();

            //Adicionando o nome do cliente
            // cliente1.Nome = "Marcos";

            // Adicionando um número e data de válidade do cartão de crédito

            // cartao1.NumeroCartaoCredito = "5249756623266551";
            // cartao1.DataValidade = "03/2028";


            // ***************** Agregando cliente com o cartão ***********************
            // cartao1.Cliente = cliente1;

            // Console.WriteLine("Cliente: {0}", cliente1.Nome);
            // Console.WriteLine("Cliente (Agregado): {0}", cartao1.Cliente.Nome);








            // Aula 02, 03 e 04
            //Criando uma estância da conta

            // Obriga a informar o numero da conta
            // Conta conta1 = new Conta(123,2000);

            // Adicionando valores nos atributos
            // conta1.Depositar(10);
            // conta1.Depositar(4500);
            // conta1.Depositar(490);
            // conta1.AlterarLimite(5000);

            // bool sacar = conta1.Sacar(10);
            // if (sacar)
            // {

            //     // Consulta através de método (precisa armazenar em variável)
            //     double saldo = conta1.ConsultaSaldoDisponivel();
            //     Console.WriteLine("Saldo Disponível: R$ {0}", saldo);

            //     // Consulta através de atributo (Não precisa armazenar em variável)
            //     Console.WriteLine("Limite Disponível: R$ {0}", conta1.Limite);

            //     Console.WriteLine("Número da Conta: {0}", conta1.NumeroConta);




            //********** Aula 01 ******************* 

            //Criando uma estâncias das conta (objeto)

            //Criando uma estância da conta
            //Conta conta1 = new Conta();
            //Conta conta2 = new Conta();


            //Atribuindo valores para a conta 1
            //conta1.Saldo = 1500;
            //conta1.Limite = 500;
            //conta1.NumeroConta = 123;

            //Atribuindo valores para a conta 2

            //conta2.Saldo = 2000;
            //conta2.Limite = 600;
            //conta2.NumeroConta = 456;



            //Console.WriteLine("Saldo: {0}", conta1.Saldo);
            //Console.WriteLine("Limite: {0}", conta1.Limite);
            //Console.WriteLine("Numero da Conta: {0}", conta1.NumeroConta);
            //Console.WriteLine("_________________________________________");
            //Console.WriteLine("Saldo: {0}", conta2.Saldo);
            //Console.WriteLine("Limite: {0}", conta2.Limite);
            //Console.WriteLine("Numero da Conta: {0}", conta2.NumeroConta);
            //Console.WriteLine("_________________________________________");

        }
    }
}
