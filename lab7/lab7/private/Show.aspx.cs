using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7.@private
{
	public partial class Show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            int cnt = dv.Table.Rows.Count;

            if (cnt == 0)
            {
                TextBox1.Text = "No comments";
            }
            else
            {
                DataRow row = dv.Table.Rows[0];
                string s = (string)row["comments"];
                TextBox1.Text = s;
            }
        }
        protected void Next_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            int cnt = dv.Table.Rows.Count;

            if (cnt == 0)
            {
                TextBox1.Text = "No comments";
            }
            
            else
            {
                int i = Int32.Parse(HiddenField1.Value);
                i++;
                if (i >= cnt)
                {
                    TextBox1.Text = "No more comments";
                    i = cnt;
                    HiddenField1.Value = i.ToString();
                }
                else
                {
                    DataRow row = dv.Table.Rows[i];
                    string s = (string)row["comments"];
                    TextBox1.Text = s;
                    HiddenField1.Value = i.ToString();
                }
            }
        }
        protected void Prev_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            int cnt = dv.Table.Rows.Count;

            if (cnt == 0)
            {
                TextBox1.Text = "No comments";
            }
            else
            {
                int i = Int32.Parse(HiddenField1.Value);
                i--;
                if(i < 0)
                {
                    TextBox1.Text = "No more comments";
                    i = -1;
                    HiddenField1.Value = i.ToString();
                }
                else
                {
                    DataRow row = dv.Table.Rows[i];
                    string s = (string)row["comments"];
                    TextBox1.Text = s;
                    HiddenField1.Value = i.ToString();
                }
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlDataSource1.Delete();
            TextBox1.Text = "No comments";
            int i = 1;
            HiddenField1.Value = i.ToString();
        }

        protected void HiddenField1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}