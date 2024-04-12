using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_NhanVien : DBConnect
    {
        public DataTable getNhanVien()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHAN_VIEN1", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }


        public bool themNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO NHAN_VIEN1(Hoten, NgaySinh, GioiTinh, TrinhDo, Luong, LoaiNV) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", nv.NHANVIEN_HOTEN, nv.NHANVIEN_NGAYSINH, nv.NHANVIEN_GIOITINH, nv.NHANVIEN_TRINHDO, nv.NHANVIEN_LUONGTHANG, nv.NHANVIEN_LOAINV);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }


        public bool suaNhanVien(DTO_NhanVien nv )
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE NHAN_VIEN1 SET HoTen = '{0}' , NgaySinh = '{1}', GioiTinh = '{2}', TrinhDo = '{3}', Luong = '{4}', LoaiNV = '{5}' where ID = '{6}'", nv.NHANVIEN_HOTEN, nv.NHANVIEN_NGAYSINH, nv.NHANVIEN_GIOITINH, nv.NHANVIEN_TRINHDO, nv.NHANVIEN_LUONGTHANG, nv.NHANVIEN_LOAINV);
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool xoaNhanVien(int ID)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM NHAN_VIEN1 WHERE ID ='{0}'", ID);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
    }
}
