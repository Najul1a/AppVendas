namespace AppVendas.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }

        public int NotaFiscal { get; set; }
        public DateTime DataVenda { get; set; }
        public double? TotalVendas { get; set; }

        /* Referencia Chave Estrangeira */
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
