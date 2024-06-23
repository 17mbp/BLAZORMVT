using CapaDeDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaNegocio
{
    public class ClassTa : InterfaceTa
    {
        private readonly InterfaceTarea _interface;
        public ClassTa(InterfaceTarea tarea)
        {
            _interface = tarea;
        }

        public void CreateTarea(Tareas tarea)
        {
            _interface.CreateTarea(tarea);
        }

        public void DeleteTarea(Tareas id)
        {
            _interface.DeleteTarea(id);
        }

        public IEnumerable<Tareas> GetAllTareas()
        {
            return _interface.GetAllTareas();
        }

        public Tareas GetTareasByListaMetaId(string idListaMeta)
        {
            return _interface.GetTareasByListaMetaId(idListaMeta);
        }

        public void UpdateTarea(Tareas tarea)
        {
            _interface.UpdateTarea(tarea);
        }
    }
}