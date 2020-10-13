using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class Connection
    {

       public static SqlConnection con = new SqlConnection(@"Server=MONPC-PC\TLMSSQLSERVER;Database=Dev1;Integrated Security=true");
      
        public void OpenCon()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void CloseCon()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
    }
}
