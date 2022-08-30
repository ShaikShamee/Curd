using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
    public class Customer:ICustomer
    {
        public int AccountId { get; set; }
        public string AccountType { get; set; }
        public string Branchcode { get; set; }
        public string CName { get; set; }
        public int CAge { get; set; }
        public double CNumber { get; set; }
        public string CEmail { get; set; }
        public string CAddress { get; set; }

        public DateTime CDateofBirth { get; set; }
        
        SqlConnection con = new SqlConnection("server=BHAVNAWKS735;database=DBCustomer;Integrated Security=true;");
        public void InsertData()
        {
            try 
            { 
            Console.Write("Enter AccountType of the customer:");
            AccountType = Console.ReadLine();
            Console.Write("");
            Branchcode = Console.ReadLine();
            Console.Write("Enter name of the customer :");
            CName = Console.ReadLine();
            Console.Write("Enter Age of the customer :");
            CAge =int.Parse(Console.ReadLine());
            Console.Write("Enter Number of the customer: ");
            CNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter email of the customer ");
            CEmail = Console.ReadLine();
            Console.WriteLine("Enter Address of the customer");
            CAddress =Console.ReadLine();

                string query1 = "insert into Account_Table1 values('" + AccountType + "'," + Branchcode + ",'" + CName + "','" + CAge + "','" + CNumber + "','" + CEmail + "','" + CAddress + "')";

            SqlCommand cmd1 = new SqlCommand(query1, con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Data inserted sucessfully");

        }
        catch (Exception)
            {
                Console.WriteLine("Enter the wrong details");
            }
        }



        public void DeleteData()
        {

            try
            {
                Console.WriteLine("Enter ID of the customer ");
                 AccountId = int.Parse(Console.ReadLine());
                string queryd = "delete from Account_Table1 where Id=" + AccountId + "";

                SqlCommand cmd = new SqlCommand(queryd, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Data deleted sucessfully");

            }
            catch (Exception)
            {
                Console.WriteLine("please give correct id");
            }

        }
    }
}
