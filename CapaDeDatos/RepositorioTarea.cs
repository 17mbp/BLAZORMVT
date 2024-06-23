using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace CapaDeDatos
{
    public class RepositorioTarea : InterfaceTarea
    {
        private readonly ApplicationDbContext _dbcontexto;
        public RepositorioTarea(ApplicationDbContext context)
        {
            _dbcontexto = context;
        }

        public void CreateTarea(Tareas tarea)
        {
            _dbcontexto.Tareas.Add(tarea);
        }

        public void DeleteTarea(CapaEntidades.Tareas id)
        {
            _dbcontexto.Tareas.Remove(id);
            _dbcontexto.SaveChanges();
        }

        public IEnumerable<Tareas> GetAllTareas()
        {
            return _dbcontexto.Set<Tareas>().ToList();
        }

        public Tareas GetTareasByListaMetaId(string idListaMeta)
        {
            return _dbcontexto.Tareas.FirstOrDefault(k => k.Tarea == idListaMeta);
        }

        public async Task PatchTareaImportante(int idTarea, bool importante)
        {
            var tarea = await _dbcontexto.Tareas.FindAsync(idTarea);

            if (tarea == null)
            {
                throw new ArgumentException("No se encontró la tarea especificada.");
            }

            tarea.Importante = importante; 
            await _dbcontexto.SaveChangesAsync();
        }

        public void UpdateTarea(Tareas tarea)
        {
            _dbcontexto.Entry(tarea).State = EntityState.Modified;
            _dbcontexto.SaveChanges();
        }
    }
}