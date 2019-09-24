using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Dominio
{
    public class Conta
    {
        public StringBuilder extrato = new StringBuilder();


        public string NumeroDaConta { get; set; }
        public string DigitoVerificador { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public  double DepositarValor {get; set;}
        public double SacarValor { get; set; }
        
        public double Deposita ()
        {
           extrato.AppendLine($"Depósito:  {DepositarValor}");
           extrato.AppendLine($"Saldo: {Saldo + DepositarValor}");
           return this.Saldo += DepositarValor;
            
        }

        public double Saca()
        {
            extrato.AppendLine($"Saque:  {SacarValor}");
            extrato.AppendLine($"Saldo: {Saldo + DepositarValor}");
            return this.Saldo -= SacarValor;
        }
        

        
        public string ExtraConta()
        {
            StringBuilder ExtraConta = new StringBuilder();

            ExtraConta.AppendLine($"Numero da Conta: { NumeroDaConta}");
            ExtraConta.AppendLine($"Digito Verificador: { DigitoVerificador}");
            
            return ExtraConta.ToString();
        }

       
    }
}
