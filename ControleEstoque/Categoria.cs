using System.ComponentModel.DataAnnotations;

namespace ControleEstoque
{
    class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [MaxLength(200)]
        public string Nome {  get; set; }
    }
}
