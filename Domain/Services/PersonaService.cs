using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Services
{
    public class PersonaService
    {
        public void Add(Persona persona)
        {
            using var context = new PersonaContext;

            context.Personas.Add(persona);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PersonaContext;
            Persona? personaToDelete = context.Personas.Find(id);
            if (personaToDelete != null)
            {
                context.Personas.Remove(personaToDelete);
                context.SaveChanges();
            }
        }
    }
}
