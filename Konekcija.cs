using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Configuration;

namespace eDnevnikproj
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
           string CS = ConfigurationManager.ConnectionStrings["kucni"].ConnectionString; 
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
        
    }
}
