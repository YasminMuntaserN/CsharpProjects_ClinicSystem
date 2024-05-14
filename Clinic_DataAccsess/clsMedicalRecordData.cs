using Clinic_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_DataAccess
{
    public class clsMedicalRecordData
    {
        public static bool GetMedicalRecordInfoByID(int MedicalRecordsID,ref string visitDescription, ref string Diagnosis, ref string Notes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM MedicalRecord WHERE MedicalRecordsID = @MedicalRecordsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalRecordsID", MedicalRecordsID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    visitDescription = (string)reader["visitDescription"];
                    Diagnosis = (string)reader["Diagnosis"];

                    
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    else
                    {
                        Notes = "";
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
        public static DataTable GetAllMedicalRecords()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM MedicalRecord";

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

        public static int AddNewMedicalRecord(string visitDescription ,string Diagnosis ,string Notes)
        {
            int MedicalRecordsID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert Into MedicalRecord(visitDescription,Diagnosis,Notes )
                          Values(@visitDescription,@Diagnosis,@Notes );
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"visitDescription", visitDescription);
            command.Parameters.AddWithValue(@"Diagnosis", Diagnosis);
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
                    MedicalRecordsID = insertedID;
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
            return MedicalRecordsID;
        }

        public static bool UpdateMedicalRecord(int MedicalRecordsID, string visitDescription , string Diagnosis, string Notes)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  MedicalRecord  
                            set visitDescription = @visitDescription,
                                Diagnosis = @Diagnosis,
                                Notes = @Notes,
                                where MedicalRecordsID = @MedicalRecordsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalRecordsID", MedicalRecordsID);
            command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            command.Parameters.AddWithValue("@visitDescription", visitDescription);
            if (Notes != "" && Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

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

        public static bool IsMedicalRecordExist(int MedicalRecordID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM MedicalRecord WHERE MedicalRecordID = @MedicalRecordID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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
