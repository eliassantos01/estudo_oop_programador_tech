using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IConta
    {
        void Depositar(double valor);

        public bool Sacar(double valor);

        void AlterarLimite(double valor);
        double ConsultarSaldoDisponivel();


    }
}
