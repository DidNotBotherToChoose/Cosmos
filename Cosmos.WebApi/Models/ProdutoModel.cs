using Cosmos.CosmosIden;

namespace Cosmos.WebApi.Models
{
    public class ProdutoModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public decimal PrecoCusto { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; } // soft delete
        public Categoria Categoria { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
