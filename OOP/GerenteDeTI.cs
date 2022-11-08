using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class GerenteDeTI : Gerente
    {
        public override void ReajustarSalario()
        {
            this.Salario += 2000;
        }
    }
}
