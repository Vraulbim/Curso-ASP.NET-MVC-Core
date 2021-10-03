using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="É necessário preencher o título")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="Título precisa ter de 3 a 60 caracteres")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage ="É necessário informar a data de lançamento")]
        [DataType(DataType.DateTime, ErrorMessage ="Insira uma data de formato correto!")]
        [Display(Name ="Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage ="Insira o genero do filme")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""''\w-]*$", ErrorMessage ="A expressão inserida não é valida")]
        [StringLength(30, ErrorMessage ="Tamanho máximo de 30 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage ="O valor é obrigatório")]
        [Range(0, 1000, ErrorMessage ="Valor de ser de até 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage ="Formato de avaliação inválido"), Required(ErrorMessage ="O campo gênero é requerido!")]
        [Display(Name ="Avaliação")]
        public int Avaliacao { get; set; }
    }
}
