using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ado_dmeo
{
    internal class Program_crud
    {
           static void Main()
           {
               try
               {
                   SqlConnection con = new SqlConnection("Data Source=DESKTOP-J04QM9U\\SQLEXPRESS;initial catalog=LTI;integrated security=true");
                   //con.Open();
                   // Console.WriteLine("Connection Established");

                   SqlCommand com = new SqlCommand();
                   com.Connection = con;
                   Console.WriteLine("SELECT OPERATION");
                   Console.WriteLine("1-Insert");
                   Console.WriteLine("2-Update");
                   Console.WriteLine("3-Delete");
                int i = Convert.ToInt32(Console.ReadLine());
                switch(i)
                {
                    case 1:
                        {
                            com.CommandText = "insert into productdb(pid,pname) values(@pid,@pname)";
                            SqlParameter p1 = new SqlParameter("@pid", SqlDbType.Int);
                            SqlParameter p2 = new SqlParameter("@pname", SqlDbType.VarChar);
                            int id = Convert.ToInt32(Console.Read());
                            string pname = Console.ReadLine();
                            p1.Value = id;
                            p2.Value = pname;
                            com.Parameters.Add(p1);
                            com.Parameters.Add(p2);
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Select 1 for pid, 2 for pname, 3 for price");
                            int j= Convert.ToInt32(Console.ReadLine());
                            switch(j)
                            {
                                case 1:
                                    {
                                        com.CommandText = "Update productdb1 set pid where ";
                                    }
                                    break;
                            }
                        }
                        break;

                    case 3:
                        break;

                }
                   

                /*   com.CommandText = "delete from productdb1 where pname=@pname";
                   //SqlParameter p1 = new SqlParameter("@pid", SqlDbType.Int);
                    SqlParameter p2 = new SqlParameter("@pname", SqlDbType.VarChar);
                   // int id = Convert.ToInt32(Console.Read());
                   Console.WriteLine("Enter a product name to be deleted");
                    string pname = Console.ReadLine();
                   // p1.Value = id;
                    p2.Value = pname;
                   // com.Parameters.Add(p1);
                   com.Parameters.Add(p2);
                */
                   con.Open();
                   com.ExecuteNonQuery();
                   Console.WriteLine("Record Updated Succesfully");
                   con.Close();

               }
               catch (SqlException ex)
               {
                   Console.WriteLine(ex.Message);
               }

           }
    }
}
