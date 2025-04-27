namespace app_mediatr.DTOs
{
    public class ClienteDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
        public bool Ativo { get; set; } = false;
    }
}
