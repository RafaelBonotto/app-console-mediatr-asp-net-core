using app_mediatr.Entities;

namespace app_mediatr.Repositorys
{
    /// <summary>
    /// Essa classe é responsável pela simulação d um repositório que retorna uma entidade Cliente
    /// </summary>
    public class ProdutoRepository
    {
        public Produto? Produto { get; set; }

        public Produto Get()
        {
            return new Produto()
            {
                Id = 1455,
                Descricao = "Garrafa",
                Preco = 18.99,
                Ativo = true
            };
        }
    }
}
