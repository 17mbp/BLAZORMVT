using System;
using System.Collections.Generic;
namespace WebApi
{
    public class CRUD
    {
        public int Id { get; set; }
        public List<LTareas> Tareas { get; set; }
        public string Estado {  get; set; }        
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Porcentaje { get; set; }
    }

    public class LTareas
    {
        public int IdTareas { get; set; }
        public string Tarea { get; set; }
        public bool? Importante { get; set; }
    }
}