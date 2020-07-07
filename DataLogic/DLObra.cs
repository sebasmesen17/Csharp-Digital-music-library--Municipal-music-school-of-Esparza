using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataEntity;

namespace DataLogic
{
    public class DLObra
    {
        public static void Agregar(tbObrasMusicales obra)
        {
            DAObrasMusicales.AgregarObra(obra);
        }

        public static void Eliminar(tbObrasMusicales eliminar)
        {
            DAObrasMusicales.EliminarObras(eliminar);
        }

        public static List<tbObrasMusicales> GetAll()
        {
            return DAObrasMusicales.GetAll();
        }

        public static tbObrasMusicales GetByID(tbObrasMusicales editar)
        {
            return DAObrasMusicales.GetByID(editar);
        }

        public static List<VP_CNS_ConsultaObrasConAutor> GetVistaConsultaObrasConAutor()
        {
            return DAObrasMusicales.GetVistaConsultaObrasConAutor();
        }

        public static void Actualizar(tbObrasMusicales obra)
        {
            DAObrasMusicales.ActualizarObras(obra);
        }

        public static List<VP_CNS_ConsultaObrasConAutor> FilterByGenero(tbObrasMusicales obra)
        {
            return DAObrasMusicales.FilterByGenero(obra);
        }

        public static List<VP_CNS_ConsultaObrasConAutor> FilterByAutor(tbObrasMusicales obra)
        {
            return DAObrasMusicales.FilterByAutor(obra);
        }

        public static List<VP_CNS_ConsultaObrasConAutor> FilterByBoth(tbObrasMusicales obra)
        {
            return DAObrasMusicales.FilterByBoth(obra);
        }
    }
}
