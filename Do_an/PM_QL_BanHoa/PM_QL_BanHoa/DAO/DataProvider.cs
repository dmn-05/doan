using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QL_BanHoa.DAO
{
    public class DataProvider
    {
        private string ConnectionSTR = "Data Source=LAPTOP-F8I3O6B7\\SQLEXPRESS01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionSTR))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
