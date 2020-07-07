using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;
using DataAccess;
using System.Transactions;
using System.Windows.Forms;

namespace DataLogic
{
    public class DLRegistroAutor
    {


        public static void Agregar(tbAutor autor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DARegistroAutor.Agregar(autor);
                    scope.Complete();
                }

            }
            catch
            {
                string msj = "La cédula que introduce ya existe, verifique de nuevo";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<tbAutor> GetAll()
        {
            return DARegistroAutor.GetAll();
        }

        public static void Eliminar(tbAutor eliminar)
        {
            DARegistroAutor.Eliminar(eliminar);
        }

        public static tbAutor GetByID(tbAutor editar)
        {
            return DARegistroAutor.GetByID(editar);
        }

        public static void Actualizar(tbAutor autor)
        {
            DARegistroAutor.Actualizar(autor);
        }
    }
}
