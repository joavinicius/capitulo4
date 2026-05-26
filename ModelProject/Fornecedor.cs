using System;
using System.Collections.Generic;
using System.Text;

namespace ModelProject
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
        public required string CNPJ { get; set; }
    }
}
