using app_mediatr.DTOs;

namespace app_mediatr.Entities
{
    /// <summary>
    /// Essa classe utiliza como exemplo o explicity operator para converter a entidade em um DTO
    /// </summary>
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
        public bool Ativo { get; set; } = false;    
        
        /// <summary>
        /// Metodo responsável pela conversão da entidade em um DTO
        /// </summary>
        /// <param name="entity"></param>
        public static explicit operator ClienteDTO(Cliente entity)
        {
            return new ClienteDTO 
            { 
                Id = entity.Id,
                Nome = entity.Nome, 
                Email = entity.Email, 
                Idade = entity.Idade, 
                Ativo = entity.Ativo 
            };
        }
    }
}
