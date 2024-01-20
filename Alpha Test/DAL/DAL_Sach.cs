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
    public class DAL_Sach
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllSach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertSach(Entity_QLSach sach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertSach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSach", SqlDbType.VarChar, 50);
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaTL", SqlDbType.VarChar, 10);
            command.Parameters.Add("@DonGia", SqlDbType.Int);
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgayTao", SqlDbType.Date);


            command.Parameters["@MaSach"].Value = sach.MaSach1;
            command.Parameters["@TenSach"].Value = sach.TenSach1;
            command.Parameters["@MaTL"].Value = sach.MaTL1;
            command.Parameters["@DonGia"].Value = sach.DonGia1;
            command.Parameters["@TrangThai"].Value = sach.TrangThai1;
            command.Parameters["@NgayTao"].Value = sach.NgayTao1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateSach(Entity_QLSach sach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateSach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSach", SqlDbType.VarChar, 50);
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaTL", SqlDbType.VarChar, 10);
            command.Parameters.Add("@DonGia", SqlDbType.Int);
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgayTao", SqlDbType.Date);


            command.Parameters["@MaSach"].Value = sach.MaSach1;
            command.Parameters["@TenSach"].Value = sach.TenSach1;
            command.Parameters["@MaTL"].Value = sach.MaTL1;
            command.Parameters["@DonGia"].Value = sach.DonGia1;
            command.Parameters["@TrangThai"].Value = sach.TrangThai1;
            command.Parameters["@NgayTao"].Value = sach.NgayTao1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteSach(string masach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteSach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSach", SqlDbType.VarChar, 50);

            command.Parameters["@MaSach"].Value = masach;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }   
    }
}
