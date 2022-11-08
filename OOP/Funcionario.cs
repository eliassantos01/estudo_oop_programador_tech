using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public abstract class Funcionario
    {
        public string Nome { get; private set; }
        public double Salario { get; set; }

        public abstract void ReajustarSalario();

        public void AdicionarNome(string primeiroNome, string sobrenome)
        {
            string nomeCompleto = primeiroNome + " " + sobrenome;
            this.Nome = nomeCompleto;
        }
       
        public void AdicionarSalarioPadrao(double salario)
        {
            this.Salario = salario;
        }
    }
}
