using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Estrutura inicial demonstrando os princípios SOLID

// SRP (Single Responsibility Principle)
// Violação:
namespace SOLID.SRP.Violacao.Models
{
    public class Funcionario
    {
        public void CalcularSalario() { /* cálculo */ }
        public void GerarRelatorioPDF() { /* violação - responsabilidade a mais */ }
    }
}

// Solução:
namespace SOLID.SRP.Solucao.Models
{
    public class Funcionario
    {
        public void CalcularSalario() { }
    }

    public class GeradorRelatorio
    {
        public void GerarPDF(Funcionario funcionario) { }
    }
}


