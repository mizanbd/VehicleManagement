using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vehicle_Schedule_Management.Model;
using Vehicle_Schedule_Management.DAL;

namespace Vehicle_Schedule_Management.BLL
{
    public class VehicleManager
    {
        VehicleGateway aVehicleGateway = new VehicleGateway();
        public string InsertVehicle(Vehicle aVehicle)
        {

            int affectedRow= aVehicleGateway.InsertVehicle(aVehicle);

            if (affectedRow > 0)
            {
                return "Vehicle Saved";
            }
            else
            {
                return "Vehicle not saved!!!!";
            }

        }

        public string SetSechedule(Sechedule aSechedule)
        {
            int affectedRow = aVehicleGateway.SetSechedule(aSechedule);

            if (affectedRow > 0)
            {
                return " Vehicle sechedul saved";
            }
            else
            {
                return "Opps!!!!! Vehicle sechedul not save";
            }
                
        }

        public SecheduleInfo GetVehicle(SecheduleInfo aSecheduleInfo)
        {
            return aVehicleGateway.GetVehicle(aSecheduleInfo);
        }
    }
}