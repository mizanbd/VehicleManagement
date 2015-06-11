using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vehicle_Schedule_Management.Model;
using System.Configuration;
using System.Data.SqlClient;


namespace Vehicle_Schedule_Management.DAL
{
    public class VehicleGateway
    {
        String connectionConfig = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

        public int InsertVehicle(Vehicle aVehicle)
        {
            SqlConnection connection = new SqlConnection(connectionConfig);

            String query = " INSERT INTO tbl_VehicleInfo VALUES('" + aVehicle.regNo + "', '" + aVehicle.engineNo + "') ";

            SqlCommand aCommand = new SqlCommand(query,connection);

            connection.Open();
            int affectedRow = aCommand.ExecuteNonQuery();
            connection.Close();
            return affectedRow;
        }


        public int SetSechedule(Sechedule aSechedule)
        {
            SqlConnection connection = new SqlConnection(connectionConfig);

            String query = " INSERT INTO Table_1 VALUES('" + aSechedule.vehicleId + "', '" +aSechedule.date +"', '" +aSechedule.shift +"', '" +aSechedule.bookedBy +"', '" +aSechedule.address +"') ";

            SqlCommand aCommand = new SqlCommand(query, connection);

            connection.Open();
            int affectedRow = aCommand.ExecuteNonQuery();
            connection.Close();
            return affectedRow;
        }

      
        public SecheduleInfo GetVehicle(SecheduleInfo aSecheduleInfo)
        {
            
            SqlConnection connection = new SqlConnection(connectionConfig);

            String query = "SELECT Select_Date,Select_Shift from Table_1 where Vehicle_id ='" + aSecheduleInfo.vehicleId +
                           "'";
            SqlCommand aCommand = new SqlCommand(query,connection);

           connection.Open();

            SqlDataReader aReader = aCommand.ExecuteReader();
            SecheduleInfo aSecheduleinfo = new SecheduleInfo();
            while (aReader.Read())
            {
               
                aSecheduleinfo.date = aReader["Select_Date"].ToString();
                aSecheduleinfo.bookedShift = aReader["Select_Shift"].ToString();
          

            }

            connection.Close();
            return aSecheduleinfo;
        }
    }
}