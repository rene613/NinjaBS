using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Afrekenen
{
    class Rekening
    {
        string product;
        int aantal;
        int prijs;
        int prijsTotaal;

        public void leesRekeningen()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["ReserveringenConnectionStringSQL"]
                .ConnectionString;
            sqlConnection dbConnection = new sqlConnection(connString);
        }
    }
}
