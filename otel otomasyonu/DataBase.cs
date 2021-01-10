using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace otel_otomasyonu
{
   public class DataBase
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-NP6T28C0\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
