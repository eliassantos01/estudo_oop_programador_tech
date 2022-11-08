using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    // Modificador PUBLIC está acessível em outras classes
    public abstract class Conta : IConta
    {
        
        // Construtor é sempre e obrigatório assim que criar o objeto
        public Conta(int numeroConta, double limite)
        {
            this.NumeroConta = numeroConta;
            this.Limite = limite;
            Conta.TotalContasCriadas++;
        }

        // Private: Apenas a Classe (Conta) tem o poder de fazer a alteração
        // Protect: Apenas a Classe Principal (Conta) e a Classe Herdada (ContaPoupanca) tem o poder de fazer a alteração


        // Atribrutos/propriedades da conta - Criando o modelo

        //Get: Pode ser acessado em outras Classes // Set: Pode setar o atributo em outras Classes
        protected double Saldo { get; set; }  
        public double Limite { get; private set; } // Private set para não poder alterar na classe program, somente via metodo AlterarLimite
        public int NumeroConta { get; private set; }

        // Static: Somente é acessado juntamente com a classe (Conta.TotalContasCriadas) e não pelo objeto. (Não precisa estanciar)
        public static int TotalContasCriadas { get; set; }


        // Métodos da Classe (Ações da classe)


        // void não retorna nada
        public void Depositar(double valor)
        {
            //this = Acessa os atributos da classe e manipular
            // this.Saldo = Saldo + valor;
            this.Saldo += valor;
        }

        public virtual bool Sacar(double valor)
        {
            double saldoDisponivel = ConsultarSaldoDisponivel();
            if (valor > saldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponível");
                return false;
            }
            else
            {
                this.Saldo -= valor;
                return true;

            }
        }
        public void AlterarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultarSaldoDisponivel()
        {
            return this.Saldo + this.Limite;

        }

        public static int ProximoTotalContasCriadas()
        {
            return Conta.TotalContasCriadas + 1;
        }

    }
}
