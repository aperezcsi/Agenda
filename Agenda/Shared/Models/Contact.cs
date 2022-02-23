using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Shared.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required(ErrorMessage = "El nombre no puede ser vacio")]
        public string _name { get; set; }
        [Required(ErrorMessage = "El Fijo no puede ser vacio")]
        public string _landline { get; set; }
        [Required(ErrorMessage = "El Celular no puede ser vacio")]
        public string _cellphone { get; set; }
    }
}
