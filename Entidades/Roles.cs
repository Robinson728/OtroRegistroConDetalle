using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtroRegistroConDetalle.Entidades
{
    public class Roles
    {
        [Key]

        public int RolId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool EsActivo { get; set; }

        [ForeignKey("RolId")]
        public virtual List<RolesDetalle> Detalle { get; set; }

        public Roles()
        {
            RolId = 0;
            Descripcion = string.Empty;
            FechaCreacion = DateTime.Now;
            EsActivo = true;
            Detalle = new List<RolesDetalle>();
        }
    }
}
