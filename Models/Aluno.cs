using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMvcFuncional.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é orbrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é orbrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} está no formato incorreto")]
        [Display(Name = "Data de Nascimento")] //Display serve para mostrar algo na tela, nesse caso vai mostrar "Data de nascimento" ao invés de "DataNascimento"
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres!")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "O campo {0} está em formato inválido!")] //válida o email
        [EmailAddress(ErrorMessage = "O campo {0} está em formata inválido!")] //valida o email
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formata inválido!")] //valida o email
        [Display(Name = "Confirme o email")]
        [Compare("Email", ErrorMessage = "Os emails não são iguais!")] //Compara o campo abaixo com o campo especificado
        [NotMapped] //impede que esse campo se torne uma coluna no banco de dados
        public string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, 5, ErrorMessage = "O campo {0} deve estar entre {1} e {2}")] //especifica um intervalo válido
        public int Avaliacao { get; set; }
        public bool Ativo { get; set; }
    }
}
