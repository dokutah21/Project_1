using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class DAL_HDN
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllHoaDonNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertHDN(Entity_HDN hdn)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertHoaDonNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDN", SqlDbType.VarChar, 10);
            command.Parameters.Add("@NgayNhap", SqlDbType.Date);
            command.Parameters.Add("@NgayNhan", SqlDbType.Date);
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MaKho", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TongTien", SqlDbType.Int);


            command.Parameters["@MaHDN"].Value = hdn.MaHDN1;
            command.Parameters["@NgayNhap"].Value = hdn.NgayNhap1;
            command.Parameters["@NgayNhan"].Value = hdn.NgayNhan1;
            command.Parameters["@MaNV"].Value = hdn.MaNV1;
            command.Parameters["@MaKho"].Value = hdn.MaKho1;
            command.Parameters["@TrangThai"].Value = hdn.TrangThai1;
            command.Parameters["@TongTien"].Value = hdn.TongTien1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateHDN(Entity_HDN hdn)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateHoaDonNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDN", SqlDbType.VarChar, 10);
            command.Parameters.Add("@NgayNhap", SqlDbType.Date);
            command.Parameters.Add("@NgayNhan", SqlDbType.Date);
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MaKho", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TongTien", SqlDbType.Int);


            command.Parameters["@MaHDN"].Value = hdn.MaHDN1;
            command.Parameters["@NgayNhap"].Value = hdn.NgayNhap1;
            command.Parameters["@NgayNhan"].Value = hdn.NgayNhan1;
            command.Parameters["@MaNV"].Value = hdn.MaNV1;
            command.Parameters["@MaKho"].Value = hdn.MaKho1;
            command.Parameters["@TrangThai"].Value = hdn.TrangThai1;
            command.Parameters["@TongTien"].Value = hdn.TongTien1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteHDN(string mahdn)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteHoaDonNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDN", SqlDbType.VarChar, 10);

            command.Parameters["@MaHDN"].Value = mahdn;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
