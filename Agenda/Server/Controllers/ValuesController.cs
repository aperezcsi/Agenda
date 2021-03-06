using Agenda.Shared.Models;
using FilmCrud.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Contact> GetContacts()
        {
            return _context.Contacts.ToList();
        }

        [HttpGet("{name}")]
        public Contact GetContactByName(string name) 
        {

            return _context.Contacts.SingleOrDefault(e => e._name == name);
            
        }

        [HttpGet("isExist/{name}")]
        public bool isExist(string name)
        {
            if(_context.Contacts.SingleOrDefault(e => e._name == name) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            var emp = _context.Contacts.SingleOrDefault(x => x._name == name);
            if (emp == null)
            {
                return NotFound("El contacto "+name+" No existe");
            }

            _context.Contacts.Remove(emp);
            _context.SaveChanges();
            return Ok("El contacto fue eliminado satisfactoriamente");
        }

        /*[HttpDelete("{contact}")]
        public bool DeleteContact(Contact contact)
        {
            var resp = (Contact)dgvOrderLin.SelectedRows[0].DataBoundItem;

            var del = _context.Contacts.SingleOrDefault(item => item._name == resp._name);

            if (del != null)
            {
              
                _context.Contacts.Remove(del);
                _context.SaveChanges();
                return true;
            }

            return false;
        }*/

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
           _context.Contacts.Add(contact);
           _context.SaveChanges();
            return Ok("Contacto Agregado satisfactoriamente");
        }

        [HttpPut("{name}")]
        public IActionResult Update (string name, Contact contact)
        {
            var emp = _context.Contacts.SingleOrDefault(x => x._name == name);
            if (emp == null)
            {
                return NotFound("El contacto " + name + " No existe");
            }
            if(contact._name != null)
            {
                emp._name = contact._name;
            }
            if(contact._landline != null)
            {
                contact._landline = contact._landline;
            }
            if(contact._cellphone != null)
            {
                contact._cellphone = contact._cellphone;
            }
            _context.Update(emp);
            _context.SaveChanges();
            return Ok("Contacto modificado");
        }

    }

}
