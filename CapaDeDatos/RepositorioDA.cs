using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
namespace CapaDeDatos
{
    public class RepositorioDA  : InterfaceDA 
    {
        private readonly ApplicationDbContext _dbcontexto;
        public RepositorioDA(ApplicationDbContext contexto)
        {
            _dbcontexto = contexto;
        }

        public void Delete(int id)
        {
            var meta = _dbcontexto.ListaMetas.Find(id);
            if (meta != null)
            {
                _dbcontexto.Tareas.RemoveRange(meta.Tareas);
                _dbcontexto.ListaMetas.Remove(meta);
                _dbcontexto.SaveChanges();
            }
        }

        public IEnumerable<ListaMetas> GetAll()
        {
            return _dbcontexto.ListaMetas.ToList();
        }

        public ListaMetas GetById(int id)
        {
            return _dbcontexto.ListaMetas.FirstOrDefault(m => m.Id == id);
        }

        public void Insert(ListaMetas data)
        {
            _dbcontexto.ListaMetas.Add(data);
            _dbcontexto.SaveChanges();
        }

        public void Update(ListaMetas data)
        {
            _dbcontexto.Entry(data).State = EntityState.Modified;
            _dbcontexto.SaveChanges();
        }
    }
}