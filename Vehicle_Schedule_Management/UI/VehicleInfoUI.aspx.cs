using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vehicle_Schedule_Management.Model;
using Vehicle_Schedule_Management.BLL;

namespace Vehicle_Schedule_Management
{
    public partial class VehicleInfoUI : System.Web.UI.Page
    {
        VehicleManager aVehicleManager = new VehicleManager();
        protected void Page_Load(object sender, EventArgs e)
        {
         

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Vehicle aVehicle = new Vehicle();

            aVehicle.regNo = regNoTextBox.Text;
            aVehicle.engineNo = engineNoTextBox.Text;

           string affectedRow= aVehicleManager.InsertVehicle(aVehicle);


            regNoTextBox.Text = string.Empty;
            engineNoTextBox.Text = string.Empty;
        }
    }
}