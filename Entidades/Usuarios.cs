using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OtroRegistroConDetalle.Entidades
{
    public class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }
        public string Alias { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
        public bool Activo { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Rol { get; set; }
    }
}
