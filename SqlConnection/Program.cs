
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.SqlConn;
using System.Data.SqlClient;

namespace ConnectSQLServer
{
    class Program
    {


        public static void Main(string[] args)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string searchString = "SELECT* FROM People WHERE FullName like '%'+@FullName+'%'";
            string updateString;

            Console.WriteLine("Type in a name you are searching for: ");
            string userSearchTerm = Console.ReadLine();



            
            SqlCommand searchCommand = new SqlCommand(searchString, conn);
            searchCommand.Parameters.AddWithValue("@FullName", userSearchTerm);
            SqlDataReader searchReader = searchCommand.ExecuteReader();




            if (searchReader.HasRows)
            {

                while (searchReader.Read())
                {

                    Console.WriteLine(String.Format("Full Name: {0}, Phone Number: {1}", searchReader["FullName"], searchReader["Phone"]));

                    Console.ReadLine();
                }

            }

            else
            {
                Console.WriteLine("No results found!");
                Console.ReadLine();
            }


            searchReader.Close();
        }

        
    }

}