using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace lab6
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedItem == null)
            {
                error.Text = "Please select a candidate!";
                return;
            }
            else
            {
                error.Text = "";
                int count = 0;
                DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                //   if(dv == null)
                DataRow row = dv.Table.Rows[RadioButtonList1.SelectedIndex];
                count = (int)row["Votes"];
                count++;
                HiddenField1.Value = count.ToString();
                SqlDataSource1.Update();
                string url = "Results.aspx";
                Response.Redirect(url);
                RadioButtonList1.ClearSelection();
            }
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}