using Clinic_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_DataAccess
{
    public class clsPaymentData
    {
        public static bool GetPaymentInfoByID(int paymentID,ref DateTime PaymentData,ref string PaymentMethod,ref decimal AmountPaid,
         ref string Notes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Payment WHERE paymentID = @paymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@paymentID", paymentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    paymentID = (int)reader["paymentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int AddNewPayment( DateTime PaymentDate, string paymentMethod ,decimal AmountPaid ,string Notes)
        {
            int PaymentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert Into Payment (PaymentDate ,paymentMethod,AmountPaid ,Notes )
                  Values(@PaymentDate ,@paymentMethod ,@AmountPaid ,@Notes );
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"PaymentDate", PaymentDate);
            command.Parameters.AddWithValue(@"paymentMethod", paymentMethod);
            command.Parameters.AddWithValue(@"AmountPaid", AmountPaid);
            if (Notes != "" && Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PaymentID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return PaymentID;
        }

        public static bool UpdatePayment(int PaymentID , DateTime PaymentDate, string paymentMethod, decimal AmountPaid, string Notes)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Payment  
                            set 
                                 PaymentDate =@PaymentDate,
                                 paymentMethod =@paymentMethod,
                                 AmountPaid =@AmountPaid,
                                 Notes =@Notes
                                where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);
       
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@paymentMethod", paymentMethod);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            if (Notes != "" && Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Payment";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool DeletePayment(int PaymentID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Payment 
                                where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
    }
}
