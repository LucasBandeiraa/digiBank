using digiBank.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digiBank.Model
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            this.NumeroDaConta = "0001";
            Conta.NumeroDaContaSequencial++;
        }

        public double Saldo { get; private set; }
        public string NumeroDaAgencia { get; private set; }
        public string NumeroDaConta { get; protected set; }
        public static int NumeroDaContaSequencial { get; private set; }
        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
             this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if(this.Saldo > this.ConsultaSaldo())
                return false;

                this.Saldo -= valor;
                return true;
        }
        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public string GetNumeroDaAgencia()
        {
            return this.NumeroDaAgencia;
        }

        public string GetNumeroDaConta()
        {
            return this.NumeroDaConta;
        }
    }
}
