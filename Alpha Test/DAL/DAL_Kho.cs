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
    public class DAL_Kho
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllKho", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertKho(Entity_QuanLyKho kho)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertKho", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKho", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TenKho", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 100);

            command.Parameters["@MaKho"].Value = kho.MaKho1;
            command.Parameters["@TenKho"].Value = kho.TenKho1;
            command.Parameters["@DiaChi"].Value = kho.DiaChi1;
            command.Parameters["@MaNV"].Value = kho.MaNV1;
            command.Parameters["@TrangThai"].Value = kho.TrangThai1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateKho(Entity_QuanLyKho kho)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateKho", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKho", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TenKho", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 100);

            command.Parameters["@MaKho"].Value = kho.MaKho1;
            command.Parameters["@TenKho"].Value = kho.TenKho1;
            command.Parameters["@DiaChi"].Value = kho.DiaChi1;
            command.Parameters["@MaNV"].Value = kho.MaNV1;
            command.Parameters["@TrangThai"].Value = kho.TrangThai1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteKho(string makho)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteKho", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKho", SqlDbType.VarChar, 10);

            command.Parameters["@MaKho"].Value = makho;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
