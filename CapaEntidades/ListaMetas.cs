namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ListaMetas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListaMetas()
        {
            Tareas = new HashSet<Tareas>();
        }

        public int Id { get; set; }

        [StringLength(18)]
        public string Estado { get; set; }

        [StringLength(80)]
        public string Nombre { get; set; }

        public int? Porcentaje { get; set; }

        public DateTime? Fecha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tareas> Tareas { get; set; }
    }
}
