using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Examen1_programacion_rad.Models;
using System.Threading.Tasks;

namespace Examen1_programacion_rad.Controllers
{
    public class ContactosControllers
    {
        readonly SQLiteAsyncConnection _connection;

        // Constructor de clase 

        public ContactosControllers(String dbpath)
        {
            // crear una nueva conexion hacia la base de datos
            _connection = new SQLiteAsyncConnection(dbpath);

            // Crear los objetos de base de datos que vamos ocupar
            _connection.CreateTableAsync<Contactos>().Wait();
        }

        // Creacion de las operaciones CRUD - DB 
        // Create 

        public Task<int> SaveContacto(Contactos contactos)
        {
            if (contactos.id != 0)
                return _connection.UpdateAsync(contactos);
            else
                return _connection.InsertAsync(contactos);
        }

        // Read 
        public Task<List<Contactos>> GetLitsContacto()
        {
            return _connection.Table<Contactos>().ToListAsync();
        }

        public Task<Contactos> GetLitsContacts(int pid)
        {
            return _connection.Table<Contactos>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        // Delete
        public Task<int> DeleteContactos(Contactos contactos)
        {
            return _connection.DeleteAsync(contactos);
        }
    }
}
