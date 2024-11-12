﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitaTowers
{
    internal class Conto
    {
        private string nomeCliente;
        private string nomeBanca;
        private double saldo;

        public Conto(string nomeCliente, string nomeBanca, double saldo)
        {
            this.nomeCliente = nomeCliente;
            this.nomeBanca = nomeBanca; 
            this.saldo = saldo;
        }
        
        public string NomeCliente { get { return nomeCliente; } }
        public string NomeBanca { get { return nomeBanca; } }   
        public double Saldo { get { return saldo; } set { saldo = value; } }   

    }
}
