namespace app_mediatr.DTOs
{
    public class ProdutoDTO
    {
        public long Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public double Preco { get; set; }
        public bool Ativo { get; set; } = false;
    }
}
