using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Videolocadora.Model
{
    public class FilmesAtributos
    {
        [Key]
        [Column(TypeName = "int")]
        public int codFilme { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string nome { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string genero { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(4)")]
        public string anoLancamento { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string imagem { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string classificacao { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string observacao { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool ativo { get; set; }

        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime dataCadastro { get; set; }

    }
}
