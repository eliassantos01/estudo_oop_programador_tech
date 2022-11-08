using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CartaoDeCredito
    {
        public string NumeroCartaoCredito { get; set; }

        public string DataValidade { get; set; }

        // *************** Agregação da Classe Cliente com a Classe Cartão de Crédito
        public Cliente Cliente { get; set; }
    }
}
