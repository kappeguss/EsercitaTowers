using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitaTowers
{
    internal class Bancomat
    {
        private string numCarta;
        private string cvv;
        private Conto conto;

        public Bancomat(string numCarta, string cvv, Conto conto)
        {
            this.numCarta = numCarta;
            this.cvv = cvv;
            this.conto = conto;
        }

        public string NumCarta {  get { return numCarta; } }
        public string Cvv { get { return cvv; } }
        public Conto Conto { get { return conto; } set { conto = value; } }

        public void Prelievo(double denaroPrelevato)
        {
            if(conto.Saldo<denaroPrelevato) return;
            conto.Saldo -= denaroPrelevato;
            
        }

        public void Deposito(double denaroDepositato)
        {
            conto.Saldo += denaroDepositato;
        }
        



    }
}
