using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("consulta")]
    public class Consulta
    {
        [Key]
        private int id;

        private Medico medico;
        private Paciente paciente;
        private DateTime horarioAgendado;
        private Boolean realizada;

    }
}
