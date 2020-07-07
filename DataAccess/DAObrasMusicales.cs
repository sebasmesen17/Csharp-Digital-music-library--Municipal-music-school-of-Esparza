using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DAObrasMusicales
    {
        public static void AgregarObra(tbObrasMusicales obra)
        {
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    db.tbObrasMusicales.Add(obra);
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

        public static List<VP_CNS_ConsultaObrasConAutor> FilterByGenero(tbObrasMusicales obra)
        {
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            List<VP_CNS_ConsultaObrasConAutor> obrasMusicalesConAutor = new List<VP_CNS_ConsultaObrasConAutor>();
            try
            {
                obrasMusicalesConAutor = db.VP_CNS_ConsultaObrasConAutor.Where(c=> c.genero == obra.genero).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return obrasMusicalesConAutor;
        }

        public static List<VP_CNS_ConsultaObrasConAutor> FilterByBoth(tbObrasMusicales obra)
        {
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            tbAutor autor = new tbAutor();
            List<VP_CNS_ConsultaObrasConAutor> obrasMusicalesConAutor = new List<VP_CNS_ConsultaObrasConAutor>();
            try
            {
                autor = db.tbAutor.Where(c => c.idAutor == obra.idAutor).FirstOrDefault();
                obrasMusicalesConAutor = db.VP_CNS_ConsultaObrasConAutor.Where(c => c.genero == obra.genero && c.nombreCompleto == autor.nombreCompleto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return obrasMusicalesConAutor;
        }

        public static List<VP_CNS_ConsultaObrasConAutor> FilterByAutor(tbObrasMusicales obra)
        {
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            tbAutor autor = new tbAutor();
            List<VP_CNS_ConsultaObrasConAutor> obrasMusicalesConAutor = new List<VP_CNS_ConsultaObrasConAutor>();
            try
            {
                autor = db.tbAutor.Where(c => c.idAutor == obra.idAutor).FirstOrDefault();
                obrasMusicalesConAutor = db.VP_CNS_ConsultaObrasConAutor.Where(c => c.nombreCompleto == autor.nombreCompleto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return obrasMusicalesConAutor;
        }

        public static void ActualizarObras(tbObrasMusicales obraNueva)
        {
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    tbObrasMusicales obra = db.tbObrasMusicales.Where(c => c.idObra == obraNueva.idObra).FirstOrDefault();
                    obra.codigoObra = obraNueva.codigoObra;
                    obra.nombre = obraNueva.nombre;
                    obra.idAutor = obraNueva.idAutor;
                    obra.genero = obraNueva.genero;
                    obra.instrumento = obraNueva.instrumento;
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

        public static tbObrasMusicales GetByID(tbObrasMusicales editar)
        {
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            tbObrasMusicales obra = new tbObrasMusicales();
            try
            {
                obra = db.tbObrasMusicales.Where(c => c.idObra == editar.idObra).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return obra;
        }

        public static void EliminarObras(tbObrasMusicales eliminar)
        {
            using (ModelEscuelaMusica db = new ModelEscuelaMusica())
            {
                try
                {
                    tbObrasMusicales obra = new tbObrasMusicales();
                    obra = db.tbObrasMusicales.Where(c => c.idObra == eliminar.idObra).FirstOrDefault();
                    db.tbObrasMusicales.Remove(obra);
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

        public static List<tbObrasMusicales> GetAll()
        {
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            List<tbObrasMusicales> obrasMusicales = new List<tbObrasMusicales>();
            try
            {
                obrasMusicales = db.tbObrasMusicales.OrderBy(c => c.idObra).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return obrasMusicales;
        }

        public static List<VP_CNS_ConsultaObrasConAutor> GetVistaConsultaObrasConAutor()
        {
            ModelEscuelaMusica db = new ModelEscuelaMusica();
            List<tbObrasMusicales> obrasMusicales = new List<tbObrasMusicales>();
            List<VP_CNS_ConsultaObrasConAutor> obrasMusicalesConAutor = new List<VP_CNS_ConsultaObrasConAutor>();
            try
            {
                obrasMusicalesConAutor=db.VP_CNS_ConsultaObrasConAutor.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return obrasMusicalesConAutor;
        }
    }
}
