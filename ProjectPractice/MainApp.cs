using Admin;
using BankData;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjectPractice
{
    public class MainApp
    {

        static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection("server=BHAVNAWKS735;database=DBCustomer;Integrated Security=true;");

            AdminSite adminSite = new AdminSite();
            Customer customer = new Customer();
            Console.WriteLine("This is Login Page to Registered Admin");

            Console.Write("Enter your username:");
            adminSite.UserId = Console.ReadLine();
            Console.Write("Enter your password:");
            adminSite.passwordd = Console.ReadLine();
            string query = "select * from  Amdin_Table_1";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Amdin_Table_1");
            int  records= ds.Tables[0].Rows.Count;

            for (int i = 0; i < records; i++)
            {
                if (adminSite.UserId.ToString() == ds.Tables[0].Rows[i][1].ToString() && adminSite.passwordd.ToString() == ds.Tables[0].Rows[i][2].ToString())
                {
                    string register = "Success";

                    while (register.ToUpper() == "Success")
                    {
                        Console.WriteLine("Logged Successfully");

                        adminSite.MenuItem();


                        string Value = Console.ReadLine();


                        switch (Value)
                        {
                            case "Insert":
                                customer.InsertData();
                                break;
                            case "Delete":
                                customer.DeleteData();
                                break;
                            default:
                                Console.WriteLine("No Data Available here");
                                break;
                        }

                        Console.WriteLine("Do you want to continue Yes/No:");
                        register = Console.ReadLine();
                    }
                }
            }
        }


    }
}