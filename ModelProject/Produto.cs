using System;
using System.Collections.Generic;
using System.Text;

namespace ModelProject
{
    public class Produto
    {
        public Guid Id { get; set; }
        public required string Descricao { get; set; }
        public required string PrecoDeCusto { get; set; }
        public required string PrecoDeVenda { get; set; }
        public required double Estoque { get; set; }
    }
}
