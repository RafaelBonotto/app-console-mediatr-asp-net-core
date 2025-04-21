namespace app_mediatr.Entities
{
    public class Cliente
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
        public bool Ativo { get; set; } = false;
    }
}
