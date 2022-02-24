using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Agenda.Shared.Models
{
    public class Directory
    {
        [Key]
        [Required(ErrorMessage = "El tamaño es requerido")]
        public string size { get; set; }
    }
}
