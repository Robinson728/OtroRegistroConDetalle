using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OtroRegistroConDetalle.DAL;
using OtroRegistroConDetalle.Entidades;

namespace OtroRegistroConDetalle.BLL
{
    public class RolesBLL
    {
        public static bool Guardar(Roles rol)
        {
            if (!Existe(rol.RolId))
                return Insertar(rol);
            else
                return Modificar(rol);
        }

        private static bool Insertar(Roles rol)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Roles.Add(rol);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Roles rol)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM RolesDetalle where RolId={rol.RolId}");
                foreach(var anterior in rol.Detalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                    
                }
                contexto.Entry(rol).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool ELiminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var rol = contexto.Roles.Find(id);
                if(rol != null)
                {
                    contexto.Entry(rol).State = EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Roles Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Roles rol;

            try
            {
                rol = contexto.Roles.Include(e => e.Detalle).Where(p => p.RolId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return rol;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Roles.Any(e => e.RolId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool ExisteDescripcion(string pronombre, int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Roles.Any(e => e.Descripcion == pronombre);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            if (encontrado)
            {
                Roles rol = Buscar(id);

                if (rol == null)
                    return true;

                if (rol.Descripcion == pronombre)
                    encontrado = false;
            }

            return encontrado;
        }

        public static List<Roles> GetList(Expression<Func<Roles, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Roles> lista = new List<Roles>();

            try
            {
                lista = contexto.Roles.Where(criterio).ToList();
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

        public static List<Roles> GetRoles()
        {
            Contexto contexto = new Contexto();
            List<Roles> lista = new List<Roles>();

            try
            {
                lista = contexto.Roles.ToList();
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
