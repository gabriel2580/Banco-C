using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Dominio
{
   public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Cpf: {Cpf}");
            sb.AppendLine($"Data de Nascimento: {DataDeNascimento}");

            return sb.ToString();
        }

    }
}
