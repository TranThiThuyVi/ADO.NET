﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-BDUR7FC\\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True");
    }
}
