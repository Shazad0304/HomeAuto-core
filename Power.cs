using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace api
{
    public class Power
    {
        public double consumption{get;set;}




        public Power get(){
          SqlCommand ao = new SqlCommand("select pow from power where id=1",connect.get());
          SqlDataReader oo = ao.ExecuteReader();
          while(oo.Read()){
              consumption=Convert.ToDouble(oo[0]);
          }
          oo.Close();
          return this;
        }
    }
}
