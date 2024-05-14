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
    public class clsPeopleData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string Name, ref DateTime DateOfBirth,
          ref short Gender, ref string Address, ref string Phone, ref string Email, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    Name = (string)reader["Name"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
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

        public static bool GetPersonInfoByName(string Name, ref int PersonID, ref DateTime DateOfBirth,
         ref short Gender, ref string Address, ref string Phone, ref string Email, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
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

        public static int AddNewPerson(string Name, DateTime DateOfBirth,
           short Gender, string Address, string Phone, string Email, string ImagePath)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People (Name,DateOfBirth,Gender,Address,Phone, Email,ImagePath)
                             VALUES (@Name,  @DateOfBirth,@Gender,@Address,@Phone, @Email,@ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string Name, DateTime DateOfBirth,
           short Gender, string Address, string Phone, string Email, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  People  
                            set Name = @Name,
                                DateOfBirth = @DateOfBirth,
                                Gender=@Gender,
                                Address = @Address,  
                                Phone = @Phone,
                                Email = @Email ,
                                ImagePath = @ImagePath 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
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

        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"";

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

        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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

        public static bool IsPersonExist(string Name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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

    }
}
