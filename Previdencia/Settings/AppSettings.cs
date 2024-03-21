using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previdencia.Settings
{
    public class AppSettings
    {
        public static string ConnectionString
            => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Previdencia;Integrated Security=True;";
    }
}
