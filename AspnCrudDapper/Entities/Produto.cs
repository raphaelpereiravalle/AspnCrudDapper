using System;
using System.ComponentModel.DataAnnotations;

namespace AspnCrudDapper.Entities
{
    public class Produto
    {
        [Key]
        [Display(Name = "Id")]
        public string ProdutoId { get; set; }
        
        [Required]
        [Display(Name = "Código do produto")]
        [StringLength(25, ErrorMessage = "O código do produto contem no maxímo 25 caracteres!")]
        public string CodProdtuto { get; set; }

        [Required]
        [Display(Name = "Nome do produto")]
        [StringLength(25, ErrorMessage = "O nome deve ter 1 até 100 caracteres!")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Estoque")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Valor deve ser maior ou igual a 1!")]
        public int Estoque { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}