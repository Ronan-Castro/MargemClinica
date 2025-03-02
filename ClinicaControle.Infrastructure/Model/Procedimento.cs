using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaControle.Infrastructure.Model
{
    public class Procedimento
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public double CustoDentistaExecutor { get; set; }
        public double CustoMaterial { get; set; }
        public double CustoProtetico { get; set; }
        public Composicao Composicao { get; set; } = new Composicao();

        // Método para calcular o custo total do procedimento (incluindo materiais e composição)
        public double CalcularCustoTotal()
        {
            return CustoMaterial + CustoProtetico + Composicao.CalcularValorTotal();
        }
    }

}
