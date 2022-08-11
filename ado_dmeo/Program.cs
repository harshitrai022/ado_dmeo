using System;

using System.Data.SqlClient;
using System.Data;

namespace ado_dmeo
{
    internal class Program
    {
      /*  static void Main(string[] args)
        {
          /* try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-J04QM9U\\SQLEXPRESS;initial catalog=LTI;integrated security=true");
                con.Open();
                Console.WriteLine("Connection Established");

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select * from productdb";
                SqlDataReader dr;
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Id :" + dr[0] +","+ " Product Name :" + dr[1]);
                }
                dr.Close();
                con.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        } */
    }
}
