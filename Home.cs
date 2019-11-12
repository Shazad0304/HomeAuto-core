using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace api
{
    public class Home
    {
        public int lightid {get;set;}

        public int lightstatus { get; set; }

        public string lightresult { get; set; }



        public Home ab(int id,int status){
            List<Home> ok3 = new List<Home>();
            SqlCommand ok = new SqlCommand($"update lights set status={status} where id={id}",connect.get());
            ok.ExecuteNonQuery();
            Home a = new Home(){lightid = id,lightstatus = status,lightresult = "Done"};
            return a;
          

        }
    }
}

