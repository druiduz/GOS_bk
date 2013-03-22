using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOS
{
    class Connexion
    {

        private Connexion()
        {
            string connStr = "DRIVER={MySQL ODBC 5.1 Driver};SERVER=localhost;UID=root;DATABASE=GOS;Password="; 
            System.Data.Odbc.OdbcConnection oConn = new System.Data.Odbc.OdbcConnection(connStr);

            try
            {
                oConn.Open();
            } 
            catch(Exception e)
            {

            }
            finally
            {
                oConn.Close();
                oConn = null;
            }
        }
    }
}
