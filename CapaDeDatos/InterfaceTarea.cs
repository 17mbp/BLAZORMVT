using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDeDatos
{
    public interface InterfaceTarea
    {
        Task PatchTareaImportante(int idTarea, bool importante);
        CapaEntidades.Tareas GetTareasByListaMetaId(string idListaMeta);
        IEnumerable<CapaEntidades.Tareas> GetAllTareas();
        void CreateTarea(CapaEntidades.Tareas tarea);
        void UpdateTarea(CapaEntidades.Tareas tarea);
        void DeleteTarea(CapaEntidades.Tareas id);
    }
}