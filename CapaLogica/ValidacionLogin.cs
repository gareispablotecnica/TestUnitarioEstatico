using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ValidacionLogin
    {
        public static bool Login(string Usuario, string Contraseña)
        {
            return (Usuario == "Admin" || Usuario == "admin") && Contraseña == "1234" ? true : false;
        }
    }
}
