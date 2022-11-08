using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ContaPoupanca : Conta // Herdando a classe Conta
    {
        // Passando os valores do parametro no construtor para preenhcer o valor da classe herdada

        public ContaPoupanca(int numeroConta, double limite) : base(numeroConta, limite) // Criando construtor da classe ContaPoupanca // "base:" pega o construtor da classe herdada
        {

        }

        public void MostrarNumeroDaConta()
        {
            Console.WriteLine("Número da Conta Poupança: {0}", this.NumeroConta);
        }

        public override bool Sacar(double valor)
        {
            bool deuCertoSaque = base.Sacar(valor);

            if (deuCertoSaque)
            {
                this.Saldo -= 6.13;
            }


            return false;
        }


    }
}
