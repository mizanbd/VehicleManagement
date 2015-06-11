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
    public partial class VehicalSecheduleUI : System.Web.UI.Page
    {
        VehicleManager aVehicleManager = new VehicleManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Sechedule aSechedule = new Sechedule();

            aSechedule.vehicleId = regNoDropDownList.SelectedItem.Text.ToString();
            aSechedule.date = DateTextBox.Text;
            aSechedule.shift = shiftDropDownList.SelectedItem.Text.ToString();
            aSechedule.bookedBy = bookedByTextBox.Text;
            aSechedule.address = addressTextBox.Text;

            aVehicleManager.SetSechedule(aSechedule);


            DateTextBox.Text = string.Empty;
            bookedByTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
        }
    }
}