using System.ComponentModel.DataAnnotations;

namespace LoginProjeto.Models
{
    public class Cliente
    {
        /*PC*/
        [Display(Name = "Código", Description = "Código.")]
        public int Id { get; set; }

        [Display(Name ="Nome completo", Description ="Nome e Sobrenome.")]
        [Required(ErrorMessage ="O nome completo é obrigatório.")]
        public string Name { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "A data é obrigatório.")]
        public string Nascimento { get; set; }

        [Display(Name ="Sexo")]
        [Required(ErrorMessage ="O Sexo é obrigatório")]
        [StringLength(1, ErrorMessage = "Deve conter 1 caracter")]

        public string Sexo {  get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O Celular é obrigatório")]
        public string Telefone { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "O Email é obrigatório")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha é obrigatório")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Situação")]
        [Required(ErrorMessage = "A Situação é obrigatório")]
        public string Situacao { get; set; }
    }
}
