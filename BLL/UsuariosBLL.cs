using System;
using System.Collections.Generic;
using System.Text;
using OtroRegistroConDetalle.Entidades;
using OtroRegistroConDetalle.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace OtroRegistroConDetalle.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            if (!Existe(usuario.UsuarioId))
                return Insertar(usuario);
            else
                return Modificar(usuario);
        }

        private static bool Insertar(Usuarios usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Usuarios.Add(usuario);
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

        private static bool Modificar(Usuarios usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(usuario).State = EntityState.Modified;
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var usuario = contexto.Usuarios.Find(id);
                if(usuario != null)
                {
                    contexto.Usuarios.Remove(usuario);
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

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Usuarios.Any(e => e.UsuarioId == id);
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

        public static Usuarios Buscar(int id)
        {
            Usuarios usuario;
            Contexto contexto = new Contexto();

            try
            {
                usuario = contexto.Usuarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return usuario;
        }

        public static bool ExisteAlias(string pronombre, int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Usuarios.Any(encontrado => encontrado.Alias == pronombre);
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
                Usuarios usuario = Buscar(id);

                if (usuario == null)
                    return true;

                if (usuario.Alias == pronombre)
                    encontrado = false;
            }

            return encontrado;
        }

        public static bool ExisteRol(string pronombre, int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Usuarios.Any(e => e.Rol == pronombre);
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
                Usuarios usuario = Buscar(id);

                if (usuario == null)
                    return true;

                if (usuario.Rol == pronombre)
                    encontrado = false;
            }

            return encontrado;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Usuarios> lista = new List<Usuarios>();

            try
            {
                lista = contexto.Usuarios.Where(criterio).ToList();
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

        public static List<Usuarios> GetUsuarios()
        {
            Contexto contexto = new Contexto();
            List<Usuarios> lista = new List<Usuarios>();

            try
            {
                lista = contexto.Usuarios.ToList();
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
