using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OtroRegistroConDetalle.Entidades
{
    public class RolesDetalle
    {
        [Key]

        public int Id { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public bool EsAsignado { get; set; }

        public RolesDetalle()
        {
            Id = 0;
            RolId = 0;
            PermisoId = 0;
            EsAsignado = true;
        }
    }
}