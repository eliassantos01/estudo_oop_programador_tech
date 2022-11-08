using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numeroConta, double limite) : base(numeroConta, limite) // Criando construtor da classe ContaPoupanca // "base:" pega o construtor da classe herdada
        {

        }



    }
}
