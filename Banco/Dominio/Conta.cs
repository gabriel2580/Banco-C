using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Dominio
{
    public class Conta
    {
        public StringBuilder Extrato = new StringBuilder();


        public string NumeroDaConta { get; set; }
        public string DigitoVerificador { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public  double DepositarValor {get; set;}
        public double SacarValor { get; set; }
        
        public double Deposita ()
        {
           return this.Saldo += DepositarValor;
        }

        public double Saca()
        {
           return this.Saldo -= SacarValor;
        }
        

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero da Conta: { NumeroDaConta}");
            sb.AppendLine($"Digito Verificador: { DigitoVerificador}");
            sb.AppendLine($"Saldo: {Saldo.ToString("###,###,###.00")}");
            sb.AppendLine($"Limite:`{Limite.ToString("###,###,###.00")}");
            return sb.ToString()
        }


    }
}
