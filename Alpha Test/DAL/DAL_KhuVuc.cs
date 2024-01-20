using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DAL
{
    public class DAL_KhuVuc
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllKhuVuc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertKV(Entity_KhuVuc kv)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertKhuVuc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKV", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TenKV", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100);

            command.Parameters["@MaKV"].Value = kv.MaKV1;
            command.Parameters["@TenKV"].Value = kv.TenKV1;
            command.Parameters["@DiaChi"].Value = kv.DiaChi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateKV(Entity_KhuVuc kv)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateKhuVuc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKV", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TenKV", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100);

            command.Parameters["@MaKV"].Value = kv.MaKV1;
            command.Parameters["@TenKV"].Value = kv.TenKV1;
            command.Parameters["@DiaChi"].Value = kv.DiaChi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteKV(string makv)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteKhuVuc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKV", SqlDbType.NVarChar, 100);

            command.Parameters["@MaKV"].Value = makv;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }  
}
