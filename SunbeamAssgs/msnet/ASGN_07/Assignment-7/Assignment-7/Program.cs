using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Choice");
            Console.WriteLine("1 . Insert    2. Update     3. Delete");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InsertUsingStoredProcedure();
                    break;

                case 2:
                    UpdateUsingStoredProcedure();
                    break;

                case 3:
                    DeleteUsingParameterizedQuery();
                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }

        public static void InsertUsingStoredProcedure()
        {
            SqlConnection sqlConnection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

                sqlConnection = new SqlConnection(ConnectionString);

                SqlCommand cmd = new SqlCommand("spInsert", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter("@Id", SqlDbType.Int);
                Console.WriteLine("Enter No");
                parameter1.Value = Convert.ToInt32(Console.ReadLine());


                SqlParameter parameter2 = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                Console.WriteLine("Enter Name");
                parameter2.Value = Console.ReadLine();


                SqlParameter parameter3 = new SqlParameter("@Address", SqlDbType.VarChar, 50);
                Console.WriteLine("Enter Address");
                parameter3.Value = Console.ReadLine();

                cmd.Parameters.Add(parameter1);
                cmd.Parameters.Add(parameter2);
                cmd.Parameters.Add(parameter3);

                sqlConnection.Open();

                cmd.ExecuteNonQuery();


                Console.WriteLine("Record Inserted using Stored Procedure...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Record Insertion Failed using Stored Procedure...");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        public static void UpdateUsingStoredProcedure()
        {
            SqlConnection sqlConnection = null;

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

                sqlConnection = new SqlConnection(ConnectionString);

                SqlCommand sqlCommand = new SqlCommand("SpUpdate", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter("@Id", SqlDbType.Int);
                Console.WriteLine("Enter No whose data is to be update");
                parameter1.Value = Convert.ToInt32(Console.ReadLine());

                SqlParameter parameter2 = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                Console.WriteLine("Enter Name");
                parameter2.Value = Console.ReadLine();

                SqlParameter parameter3 = new SqlParameter("@Address", SqlDbType.VarChar, 50);
                Console.WriteLine("Enter Address");
                parameter3.Value = Console.ReadLine();

                sqlCommand.Parameters.Add(parameter1);
                sqlCommand.Parameters.Add(parameter2);
                sqlCommand.Parameters.Add(parameter3);

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                Console.WriteLine("Record Updated using Stored Procedure...");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Record Update Failed using Stored Procedure...");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }


        public static void DeleteUsingParameterizedQuery()
        {
            SqlConnection sqlConnection = null;

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

                sqlConnection = new SqlConnection(ConnectionString);

                SqlParameter parameter1 = new SqlParameter("@Id", SqlDbType.Int);
                Console.WriteLine("Enter No whose data is to be Deleted");
                parameter1.Value = Convert.ToInt32(Console.ReadLine());

                string query = "delete from Emp where Id=@Id";

                SqlCommand sqlCommand = new SqlCommand(query , sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(parameter1);


                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                Console.WriteLine("Record Deleted Successfully");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Record Deletion Failed");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
