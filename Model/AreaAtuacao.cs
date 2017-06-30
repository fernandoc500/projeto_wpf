using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("area_atuacao")]
    class AreaAtuacao
    {
        private int id;
        private String nome;
        private decimal valorBaseConsulta;
    }
}
