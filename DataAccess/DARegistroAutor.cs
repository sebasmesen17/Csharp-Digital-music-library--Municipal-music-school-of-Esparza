using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DARegistroAutor
    {
        public static void Agregar(tbAutor autor)
        {
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    db.tbAutor.Add(autor);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
        }

        public static tbAutor GetByID(tbAutor editar)
        {
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            tbAutor autor = new tbAutor();
            try
            {
                autor = db.tbAutor.Where(c => c.idAutor == editar.idAutor).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return autor;
        }

        public static void Actualizar(tbAutor autor)
        {
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    tbAutor autorN = db.tbAutor.Where(c => c.idAutor == autor.idAutor).FirstOrDefault();
                    autorN.nombreCompleto = autor.nombreCompleto;
                    autorN.informacion = autor.informacion;
                    autorN.fechaNacimiento = autor.fechaNacimiento;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
        }

        public static void Eliminar(tbAutor eliminar)
        {
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    while(db.tbObrasMusicales.Where(c => c.idAutor == eliminar.idAutor).FirstOrDefault()!=null)
                    {
                        tbObrasMusicales obraBorrar = new tbObrasMusicales();
                        obraBorrar = db.tbObrasMusicales.Where(c => c.idAutor == eliminar.idAutor).FirstOrDefault();
                        db.tbObrasMusicales.Remove(obraBorrar);
                        db.SaveChanges();
                    }
                    //Generar loop para borrar obras asignadas a este autor
                    tbAutor autor = new tbAutor();
                    autor = db.tbAutor.Where(c => c.idAutor == eliminar.idAutor).FirstOrDefault();
                    db.tbAutor.Remove(autor);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
        }

        public static List<tbAutor> GetAll()
        {
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            List<tbAutor> autores = new List<tbAutor>();
            try
            {
                autores = db.tbAutor.OrderBy(c => c.nombreCompleto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return autores;
        }


        public static bool Login(tbAdministrador buscarAutor)
        {
            bool correct = false;
            tbAdministrador existe = new tbAdministrador();
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    existe = db.tbAdministrador.Where(c => c.cedula== buscarAutor.cedula && c.contrasenia == buscarAutor.contrasenia).FirstOrDefault();
                    if(existe!=null)
                    {
                        correct = true;
                    }
                }
                catch (Exception ex)
                {
                        throw new Exception(ex.Message);
                }
                 return correct;
            }

        }
    }
}
