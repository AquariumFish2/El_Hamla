using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace El_Hamla
{
    class CLSset
    {
        public static SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
        //public static SqlConnection cn = new SqlConnection(@"Server=DESKTOP-PO32RSJ;Database=El_Hamla;Integrated Security=True");
    }
}
