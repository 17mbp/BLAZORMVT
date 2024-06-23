namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tareas
    {
        public int? IdTareas { get; set; }

        [Key]
        [StringLength(80)]
        public string Tarea { get; set; }

        public bool? Importante { get; set; }

        public virtual ListaMetas ListaMetas { get; set; }
    }
}