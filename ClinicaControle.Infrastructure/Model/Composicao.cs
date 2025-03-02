namespace ClinicaControle.Infrastructure.Model
{
    public class Composicao
    {
        public List<ItemComposicao> Itens { get; set; } = new List<ItemComposicao>();

        // Método para calcular o valor total da composição
        public double CalcularValorTotal()
        {
            return Itens.Sum(item => item.Subtotal);
        }
    }
}