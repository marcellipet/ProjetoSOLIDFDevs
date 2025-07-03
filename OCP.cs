using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.OCP.Solucao.Interfaces;

// OCP (Open-Closed Principle)
// Violação:
namespace SOLID.OCP.Violacao
{
    public class DescontoService
    {
        public double CalcularDesconto(string tipoCliente)
        {
            if (tipoCliente == "Comum") return 0.1;
            else if (tipoCliente == "Premium") return 0.3;
            else return 0;
        }
    }
}

// Solução:
namespace SOLID.OCP.Solucao.Interfaces
{
    public interface IDesconto
    {
        double Calcular();
    }
}

namespace SOLID.OCP.Solucao
{
    public class ClienteComum : IDesconto { public double Calcular() => 0.1; }
    public class ClientePremium : IDesconto { public double Calcular() => 0.3; }
}