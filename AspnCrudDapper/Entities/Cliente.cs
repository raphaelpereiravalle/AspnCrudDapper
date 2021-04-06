using System;
using System.ComponentModel.DataAnnotations;

namespace AspnCrudDapper.Entities
{
    public class Cliente
    {
        [Key]
        public string ClienteId { get; set; }
        
        [StringLength(150)]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        [StringLength(150)]
        public string Endereco { get; set; }

        [StringLength(50)]
        public string Cidade { get; set; }

        [StringLength(50)]
        public string Bairro { get; set; }

        public DateTime? DataNascimento { get; set; }

        public DateTime DataCadastro{ get; set; }
    }
}
