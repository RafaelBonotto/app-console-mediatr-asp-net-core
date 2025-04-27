using app_mediatr.Entities;

namespace app_mediatr.Repositorys
{
    /// <summary>
    /// Essa classe é responsável pela simulação d um repositório que retorna uma entidade Cliente
    /// </summary>
    public class ClienteRepository
    {
        public Cliente? Cliente { get; set; }

        public Cliente Get()
        {
            return new Cliente()
            {
                Id = 12578,
                Nome = "Bruce Wayne",
                Email = "brucewayne@email.com",
                Idade = 30,
                Ativo = true
            };
        }
    }
}
