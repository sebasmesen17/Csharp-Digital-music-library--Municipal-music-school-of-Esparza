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
    public class DLRegistroAdmin
    {
        public static void Agregar(tbAdministrador administrador)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DARegistroAdmin.Agregar(administrador);
                    scope.Complete();
                    string msj = "Usuario registrado exitosamente";
                    MessageBox.Show(msj, "Listo");
                }

            }
            catch
            {
                string msj = "La cédula que introduce ya existe, verifique de nuevo";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static bool Login(tbAdministrador buscarAutor)
        {
            return DARegistroAutor.Login(buscarAutor);
        }

        public static void Eliminar(tbAdministrador eliminar)
        {
            DARegistroAdmin.Eliminar(eliminar);
        }

        public static object GetAll()
        {
            return DARegistroAdmin.GetAll();
        }
    }
}
