using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdParcela { get; set; }
        public double Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
