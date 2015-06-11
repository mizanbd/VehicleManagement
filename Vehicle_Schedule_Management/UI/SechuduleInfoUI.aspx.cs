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
    public partial class SechuduleInfoUI : System.Web.UI.Page
    {

        VehicleManager aVehicleManager = new VehicleManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {

           SecheduleInfo aSecheduleInfo = new SecheduleInfo();

            aSecheduleInfo.vehicleId = regNoDropDownList.SelectedItem.Text.ToString();

           
          SecheduleInfo aInfo =  aVehicleManager.GetVehicle(aSecheduleInfo);

            foreach ( SecheduleInfo sechedule in aInfo)
            {



                sechuduleGridView.DataSource = SqlDataSource2;
                sechuduleGridView.DataBind();

            }

        }
    }
}