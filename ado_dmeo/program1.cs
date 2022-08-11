using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ado_dmeo
{
  /*  internal class program1
    {
     /*  static void Main()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-J04QM9U\\SQLEXPRESS;initial catalog=LTI;integrated security=true");
                //con.Open();
               // Console.WriteLine("Connection Established");

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "insert into productdb(pid,pname) values(@pid,@pname)";
                SqlParameter p1 = new SqlParameter("@pid", SqlDbType.Int);
                SqlParameter p2 = new SqlParameter("@pname", SqlDbType.VarChar);
                int id=Convert.ToInt32(Console.Read());
                string pname=Console.ReadLine();
                p1.Value = id;
                p2.Value = pname;
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Record Added Succesfully");
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }*/
}
