using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace _36_41_ShopBanDienThoai
{
    class cls36_41_ShopBanDienThoai
    {
        SqlConnection con = new SqlConnection();
        void KetNoi()
        {
            con.ConnectionString = @"Data source=DESKTOP-M1KPN0F;Initial Catalog=QuanLyBanDienThoai;integrated Security=True";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void DongKetNoi()
        {
            con.Close();
        }
        public cls36_41_ShopBanDienThoai()
        {
            KetNoi();
         }
        public DataSet LayDuLieu(String sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(ds);
            return ds;
        }
        public int capNhatDuLieu(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();

        }
    }
}
