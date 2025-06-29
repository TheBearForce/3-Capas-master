using System;
using System.Collections.Generic;
using Entidadd;
using AccesoDatoss;

namespace LogicaNegocio
{
     public interface Class1
    {
            IEnumerable<Contact> ListarContactos();
            void AddContact(Contact c);
            void UpdateContact(Contact c);
            void DeleteContact(int id);
     }
     public class ContactService : Class1
        {
            private readonly IContactRepository _repo;
            public ContactService(IContactRepository repo)
            {
                _repo = repo;
            }
            public IEnumerable<Contact> ListarContactos()
            {
                // podrías aplicar paginación, filtros, ordenamientos... 
                return _repo.GetAll();
            }
            public void AddContact(Contact c)
            {
                if (string.IsNullOrWhiteSpace(c.Name))
                    throw new ArgumentException("El nombre es obligatorio");
                _repo.Add(c);
            }
            public void UpdateContact(Contact c)
            {
                if (c.Id <= 0)
                    throw new ArgumentException("Id no válido");
                _repo.Update(c);
            }
            public void DeleteContact(int id)
            {
                _repo.Delete(id);
            }
     }
}

