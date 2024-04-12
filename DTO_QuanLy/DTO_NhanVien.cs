using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhanVien
    {
        private int _NHANVIEN_ID;
        private string _NHANVIEN_HOTEN;
        private string _NHANVIEN_NGAYSINH;
        private string _NHANVIEN_GIOITINH;
        private string _NHANVIEN_TRINHDO;
        private string _NHANVIEN_LUONGTHANG;
        private string _NHANVIEN_LOAINV;

        public int NHANVIEN_ID
        {
            get
            {
                return _NHANVIEN_ID;
            }

            set
            {
                _NHANVIEN_ID = value;
            }
        }
        public string NHANVIEN_HOTEN
        {
            get
            {
                return _NHANVIEN_HOTEN;
            }

            set
            {
                _NHANVIEN_HOTEN = value;
            }
        }
        public string NHANVIEN_NGAYSINH
        {
            get
            {
                return _NHANVIEN_NGAYSINH;
            }

            set
            {
                _NHANVIEN_NGAYSINH = value;
            }
        }

        public String NHANVIEN_GIOITINH
        {
            get
            {
                return _NHANVIEN_GIOITINH;
            }

            set
            {
                _NHANVIEN_GIOITINH = value;
            }
        }

        public String NHANVIEN_TRINHDO
        {
            get
            {
                return _NHANVIEN_TRINHDO;
            }

            set
            {
                _NHANVIEN_TRINHDO = value;
            }
        }
        public string NHANVIEN_LUONGTHANG
        {
            get
            {
                return _NHANVIEN_LUONGTHANG;
            }

            set
            {
                _NHANVIEN_LUONGTHANG = value;
            }
        }
        public string NHANVIEN_LOAINV
        {
            get
            {
                return _NHANVIEN_LOAINV;
            }

            set
            {
                _NHANVIEN_LOAINV = value;
            }
        }
        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(int ID, string hoten, string ngaysinh,string gioitinh, string trinhdo, string luongthang, string loainv)
        {
            this.NHANVIEN_ID = ID;
            this.NHANVIEN_HOTEN = hoten;
            this.NHANVIEN_NGAYSINH = ngaysinh;
            this.NHANVIEN_GIOITINH = gioitinh;
            this.NHANVIEN_TRINHDO = trinhdo;
            this.NHANVIEN_LUONGTHANG = luongthang;
            this.NHANVIEN_LOAINV = loainv;
        }
    }
}
