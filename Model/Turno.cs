using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{

    class Turno
    {
        [Key]
        private int id;

        [Required]
        private String nome;

        [Required]
        private DateTime horarioInicio;

        [Required]
        private DateTime horarioFim;
    }
}
