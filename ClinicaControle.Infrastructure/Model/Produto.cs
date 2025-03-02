namespace ClinicaControle.Infrastructure.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Estoque { get; set; }
        public double Valor { get; set; }
        public double CalcularValorTotal() => Estoque * Valor;
    }
}