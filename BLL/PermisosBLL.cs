using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using OtroRegistroConDetalle.DAL;
using OtroRegistroConDetalle.Entidades;

namespace OtroRegistroConDetalle.BLL
{
    public class PermisosBLL
    {
        public static List<Permisos> GetList(Expression<Func<Permisos, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Permisos> lista = new List<Permisos>();

            try
            {
                lista = contexto.Permisos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Permisos> GetPermisos()
        {
            Contexto contexto = new Contexto();
            List<Permisos> lista = new List<Permisos>();

            try
            {
                lista = contexto.Permisos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
