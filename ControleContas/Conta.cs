using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas
{
    public class Conta
    {
        public Conta(long numero) 
        { 
            this.Numero = numero;
        }
        public Conta() //metódo construtor padrão
        {
            _numero = new Random().Next(1000000, 999999999);
        }
        private long _numero;
        public long Numero { //propriedade é o que tem get (leitura) e set (escrita)
            get
            {
                return _numero;
            }
            private set
            {
                _numero = value;
            }
        }
        private decimal _saldo;
        public decimal Saldo 
        { 
            get
            {
                return _saldo;
            }
            private set
            {
                _saldo = value;
            }
        }
        public void Depositar(decimal valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor tem que ser positivo.");
            }
            Saldo += valor;
        }
    }
}
