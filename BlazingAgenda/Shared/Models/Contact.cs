using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingAgenda.Shared.Models
{
    public class Contact
    {
        public string _name { get; set; }
        public string _landline { get; set; }
        public string _cellphone { get; set; }


        public Contact(string name, string landline, string cellphone)
        {
            _name = name;
            _landline = landline;
            _cellphone = cellphone;
        }
    }
}
