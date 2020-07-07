using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DARegistroAdmin
    {
        public static void Agregar(tbAdministrador administrador)
        {
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    db.tbAdministrador.Add(administrador);
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

        public static void Eliminar(tbAdministrador eliminar)
        {
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    tbAdministrador admin = new tbAdministrador();
                    admin = db.tbAdministrador.Where(c => c.cedula == eliminar.cedula).FirstOrDefault();
                    db.tbAdministrador.Remove(admin);
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

        public static List<tbAdministrador> GetAll()
        {
            List<tbAdministrador> administradores = new List<tbAdministrador>();
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            try
            {               
                administradores = db.tbAdministrador.OrderBy(c => c.cedula).ToList();
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
            return administradores;
        }
    }
}
