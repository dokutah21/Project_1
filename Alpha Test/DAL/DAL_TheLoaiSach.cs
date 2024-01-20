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
    public class DAL_TheLoaiSach
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllTheLoaiSach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertTheLoaiSach(Entity_TLSach tlsach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertTheLoaiSach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTL", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TenTL", SqlDbType.NVarChar, 100);

            command.Parameters["@MaTL"].Value = tlsach.MaTL1;
            command.Parameters["@TenTL"].Value = tlsach.TenTL1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateTheLoaiSach(Entity_TLSach tlsach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateTheLoaiSach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTL", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TenTL", SqlDbType.NVarChar, 100);

            command.Parameters["@MaTL"].Value = tlsach.MaTL1;
            command.Parameters["@TenTL"].Value = tlsach.TenTL1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteTheLoaiSach(string matl)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteTheLoaiSach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTL", SqlDbType.VarChar, 10);

            command.Parameters["@MaTL"].Value = matl;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
