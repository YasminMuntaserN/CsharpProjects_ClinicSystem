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
    public class clsAppointmentData
    {

        public static bool GetAppointmentInfoByID(int AppointmentID, ref int PatientID, ref int DoctorID
            , ref DateTime AppointmentDateAndTime, ref int StatusID, ref int MedicalRecordID, ref int PaymentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Appointment WHERE AppointmentID = @AppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    PatientID = (int)reader["PatientID"];
                    DoctorID = (int)reader["DoctorID"];
                    AppointmentDateAndTime = (DateTime)reader["AppointmentDateAndTime"];
                    StatusID = (int)reader["StatusID"];
                    if (reader["MedicalRecordID"] != DBNull.Value)
                    {
                        MedicalRecordID = (int)reader["MedicalRecordID"];
                    }
                    else
                    {
                        MedicalRecordID = -1;
                    }

                    if (reader["PaymentID"] != DBNull.Value)
                    {
                        PaymentID = (int)reader["PaymentID"];
                    }
                    else
                    {
                        PaymentID = -1;
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

        public static bool GetAppointmentInfoByPatientID(int PatientID, ref int AppointmentID, ref int DoctorID
        , ref DateTime AppointmentDateAndTime, ref int StatusID, ref int MedicalRecordID, ref int PaymentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Appointment WHERE PatientID = @PatientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    AppointmentID = (int)reader["AppointmentID"];
                    DoctorID = (int)reader["DoctorID"];
                    AppointmentDateAndTime = (DateTime)reader["AppointmentDateAndTime"];
                    StatusID = (int)reader["StatusID"];
                    StatusID = (int)reader["StatusID"];
                    if (reader["MedicalRecordID"] != DBNull.Value)
                    {
                        MedicalRecordID = (int)reader["MedicalRecordID"];
                    }
                    else
                    {
                        MedicalRecordID = -1;
                    }

                    if (reader["PaymentID"] != DBNull.Value)
                    {
                        PaymentID = (int)reader["PaymentID"];
                    }
                    else
                    {
                        PaymentID = -1;
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

        public static bool GetAppointmentInfoByDoctorIDAndAppointmentDate(int DoctorID, DateTime AppointmentDateAndTime
            , ref int PatientID, ref int AppointmentID
        , ref int StatusID, ref int MedicalRecordID, ref int PaymentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Appointment WHERE DoctorID = @DoctorID and AppointmentDateAndTime=@AppointmentDateAndTime";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@AppointmentDateAndTime", AppointmentDateAndTime);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    AppointmentID = (int)reader["AppointmentID"];
                    PatientID = (int)reader["PatientID"];
                    StatusID = (int)reader["StatusID"];
                    if (reader["MedicalRecordID"] != DBNull.Value)
                    {
                        MedicalRecordID = (int)reader["MedicalRecordID"];
                    }
                    else
                    {
                        MedicalRecordID = -1;
                    }

                    if (reader["PaymentID"] != DBNull.Value)
                    {
                        PaymentID = (int)reader["PaymentID"];
                    }
                    else
                    {
                        PaymentID = -1;
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

        public static int AddNewAppointment(int DoctorID, int PatientID
        , DateTime AppointmentDateAndTime, int StatusID, int MedicalRecordID, int PaymentID)
        {
            int AppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert Into Appointment (DoctorID ,PatientID ,AppointmentDateAndTime ,
                   StatusID ,MedicalRecordID ,PaymentID)
                  Values(@DoctorID ,@PatientID ,@AppointmentDateAndTime ,@StatusID ,@MedicalRecordID ,@PaymentID);
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"DoctorID", DoctorID);
            command.Parameters.AddWithValue(@"PatientID", PatientID);
            command.Parameters.AddWithValue(@"StatusID", StatusID);
            command.Parameters.AddWithValue(@"AppointmentDateAndTime", AppointmentDateAndTime);
            if (MedicalRecordID != -1)
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            else
                command.Parameters.AddWithValue("@MedicalRecordID", System.DBNull.Value);
            if (PaymentID != -1)
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                command.Parameters.AddWithValue("@PaymentID", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AppointmentID = insertedID;
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
            return AppointmentID;
        }


        public static bool UpdateAppointment(int AppointmentID, int DoctorID, int PatientID
        , DateTime AppointmentDateAndTime, int StatusID, int MedicalRecordID, int PaymentID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Appointment  
                            set DoctorID = @DoctorID,
                                 PatientID =@PatientID,
                                 AppointmentDateAndTime =@AppointmentDateAndTime,
                                 StatusID =@StatusID,
                                 MedicalRecordID =@MedicalRecordID
                                where AppointmentID = @AppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@StatusID", StatusID);
            command.Parameters.AddWithValue(@"AppointmentDateAndTime", AppointmentDateAndTime);
            if (MedicalRecordID != -1)
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            else
                command.Parameters.AddWithValue("@MedicalRecordID", System.DBNull.Value);
            if (PaymentID != -1)
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                command.Parameters.AddWithValue("@PaymentID", System.DBNull.Value);
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

        public static DataTable GetAllAppointments()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM AppointmentInfo";

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

        public static bool DeleteAppointment(int AppointmentID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Appointment 
                                where AppointmentID = @AppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        public static int GetAppointmentsCount()
        {
            int Total = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select count(*) from Appointment";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int total))
                {
                    Total = total;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Total;
        }

    }


}
