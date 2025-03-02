namespace ClinicaControle.Infrastructure.Model
{
    public class ItemComposicao
    {
        public int Id { get; set; }
        public Produto Produto { get; set; } = new Produto();
        public int Quantidade { get; set; }
        public double Subtotal => Quantidade * Produto.Valor;
    }
}