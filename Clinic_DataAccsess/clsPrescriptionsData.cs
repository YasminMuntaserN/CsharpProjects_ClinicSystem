using Clinic_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_DataAccess
{
    public class clsPrescriptionsData
    {
        
        public static bool GetPrescriptionInfoByPrescriptionID(int PrescriptionID, ref int MedicalRecordID,
           ref string MedicationName ,ref string Dosage , ref string Frequency,ref DateTime StartDate,
           ref DateTime EndDate, ref string SpecialInstructions)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Prescriptions WHERE PrescriptionID = @PrescriptionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    MedicalRecordID = (int)reader["MedicalRecordID"];
                    MedicationName = (string)reader["MedicationName"];
                    Dosage = (string)reader["Dosage"];
                    Frequency = (string)reader["Frequency"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];
                    SpecialInstructions = (string)reader["SpecialInstructions"];
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

    
        public static int AddNewPrescriptions( int MedicalRecordID,
            string MedicationName,  string Dosage, string Frequency,  DateTime StartDate,
           DateTime EndDate, string SpecialInstructions)
        {
            int PrescriptionID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert Into Prescriptions (MedicalRecordID ,MedicationName ,Dosage ,
                   Frequency ,StartDate ,EndDate,SpecialInstructions)
                  Values(@MedicalRecordID ,@MedicationName ,@Dosage ,@Frequency ,@StartDate ,@EndDate ,@SpecialInstructions);
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"MedicalRecordID", MedicalRecordID);
            command.Parameters.AddWithValue(@"MedicationName", MedicationName);
            command.Parameters.AddWithValue(@"Dosage", Dosage);
            command.Parameters.AddWithValue(@"Frequency", Frequency);
            command.Parameters.AddWithValue(@"StartDate", StartDate);
            command.Parameters.AddWithValue(@"EndDate", EndDate);
            command.Parameters.AddWithValue(@"SpecialInstructions", SpecialInstructions);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PrescriptionID = insertedID;
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
            return PrescriptionID;
        }


        public static bool UpdatePrescription(int PrescriptionID, int MedicalRecordID,
            string MedicationName, string Dosage, string Frequency, DateTime StartDate,
           DateTime EndDate, string SpecialInstructions)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Prescription  
                            set MedicalRecordID = @MedicalRecordID,
                                 MedicationName =@MedicationName,
                                 Dosage =@Dosage,
                                 Frequency =@Frequency,
                                 StartDate =@StartDate
                                 EndDate =@EndDate,
                                 SpecialInstructions =@SpecialInstructions,
                                where PrescriptionID = @PrescriptionID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            command.Parameters.AddWithValue("@MedicationName", MedicationName);
            command.Parameters.AddWithValue("@Dosage", Dosage);
            command.Parameters.AddWithValue("@Frequency", Frequency);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
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

        public static DataTable GetAllPrescription()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Prescriptions";

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

        public static bool IsPrescriptionExist(int MedicalRecordID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Prescriptions WHERE MedicalRecordID = @MedicalRecordID";

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
