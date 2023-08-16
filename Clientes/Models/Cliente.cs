using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clientes
{

    [Table("Produto")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public Guid Id { get; set; }



        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        

    }
}
