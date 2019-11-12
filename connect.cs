using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace api
{
public static class connect{

   public static SqlConnection ab;
   public static SqlConnection get(){
       if(ab != null){
           return ab;
       }
       else{
           ab = new SqlConnection();
           ab.ConnectionString = "workstation id=homeauto.mssql.somee.com;packet size=4096;user id=Shazad0304_SQLLogin_1;pwd=rb2rik57vw;data source=homeauto.mssql.somee.com;persist security info=False;initial catalog=homeauto";
           ab.Open();
       }
       return ab;
   }
}


}