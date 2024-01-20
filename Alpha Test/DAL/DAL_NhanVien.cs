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
    public class DAL_NhanVien
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllNhanVien",Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        
        public static void InsertNV(Entity_QLNV nv)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertNhanVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@QuocTich", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DanToc", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@SoDienThoai", SqlDbType.Char, 10);
            command.Parameters.Add("@CCCD", SqlDbType.Char, 12);
            command.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            command.Parameters.Add("@DiaChiHienTai", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaKV", SqlDbType.NVarChar, 100);


            command.Parameters["@MaNV"].Value = nv.MaNV1;
            command.Parameters["@HoTen"].Value = nv.HoTen1;
            command.Parameters["@QuocTich"].Value = nv.QuocTich1;
            command.Parameters["@DanToc"].Value = nv.DanToc1;
            command.Parameters["@GioiTinh"].Value = nv.GioiTinh1;
            command.Parameters["@NgaySinh"].Value = nv.NgaySinh1;
            command.Parameters["@ChucVu"].Value = nv.ChucVu1;
            command.Parameters["@QueQuan"].Value = nv.QueQuan1;
            command.Parameters["@SoDienThoai"].Value = nv.SoDienThoai1;
            command.Parameters["@CCCD"].Value = nv.CCCD1;
            command.Parameters["@Email"].Value = nv.Email1;
            command.Parameters["@DiaChiHienTai"].Value = nv.DiaChiHienTai1;
            command.Parameters["@MaKV"].Value = nv.MaKV1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateNV(Entity_QLNV nv)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateNhanVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@QuocTich", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DanToc", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@SoDienThoai", SqlDbType.Char, 10);
            command.Parameters.Add("@CCCD", SqlDbType.Char, 12);
            command.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            command.Parameters.Add("@DiaChiHienTai", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaKV", SqlDbType.NVarChar, 100);


            command.Parameters["@MaNV"].Value = nv.MaNV1;
            command.Parameters["@HoTen"].Value = nv.HoTen1;
            command.Parameters["@QuocTich"].Value = nv.QuocTich1;
            command.Parameters["@DanToc"].Value = nv.DanToc1;
            command.Parameters["@GioiTinh"].Value = nv.GioiTinh1;
            command.Parameters["@NgaySinh"].Value = nv.NgaySinh1;
            command.Parameters["@ChucVu"].Value = nv.ChucVu1;
            command.Parameters["@QueQuan"].Value = nv.QueQuan1;
            command.Parameters["@SoDienThoai"].Value = nv.SoDienThoai1;
            command.Parameters["@CCCD"].Value = nv.CCCD1;
            command.Parameters["@Email"].Value = nv.Email1;
            command.Parameters["@DiaChiHienTai"].Value = nv.DiaChiHienTai1;
            command.Parameters["@MaKV"].Value = nv.MaKV1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteNV(string manv)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteNhanVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);

            command.Parameters["@MaNV"].Value = manv;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
