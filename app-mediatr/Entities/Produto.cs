using app_mediatr.DTOs;

namespace app_mediatr.Entities
{
    /// <summary>
    /// Essa classe utiliza como exemplo o implicity operator para converter a entidade em um DTO
    /// </summary>
    public class Produto
    {
        public long Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public double Preco { get; set; }
        public bool Ativo { get; set; } = false;

        /// <summary>
        /// Metodo responsável pela conversão da entidade em um DTO
        /// </summary>
        /// <param name="entity"></param>
        public static implicit operator ProdutoDTO(Produto entity)
        {
            return new ProdutoDTO
            {
                Id = entity.Id,
                Descricao = entity.Descricao,
                Preco = entity.Preco,
                Ativo = entity.Ativo
            };
        }
    }
}
