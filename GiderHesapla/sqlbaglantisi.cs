﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace GiderHesapla
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-BAGITOD;Initial Catalog=DboGiderHesapla;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
