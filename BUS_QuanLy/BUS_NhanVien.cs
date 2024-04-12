using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanvien = new DAL_NhanVien();

        public DataTable getNhanVien()
        {
            return dalNhanvien.getNhanVien();
        }

        public bool themNhanVien(DTO_NhanVien nv)
        {
            return dalNhanvien.themNhanVien(nv);
        }
        public bool suaNhanVien(DTO_NhanVien nv)
        {
            return dalNhanvien.suaNhanVien(nv);
        }
        public bool xoaNhanVien(int ID)
        {
            return dalNhanvien.xoaNhanVien(ID);
        }
    }
}
