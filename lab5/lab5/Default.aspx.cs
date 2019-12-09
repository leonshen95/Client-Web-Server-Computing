using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            inputString.Text = "";
        }

        protected void convert_Click(object sender, EventArgs e)
        {
            error.Text = "";
            output.Text = "";
            if(inputString.Text == string.Empty || IsDigitsOnly(inputString.Text) == false)
            {
                error.Text = "Please enter a valid input";
                return;
            }
            double input = Convert.ToDouble(inputString.Text);
            if(fromUnit.SelectedItem != null && toUnit.SelectedItem != null)
            {
                if(fromUnit.SelectedItem.Equals(toUnit.SelectedItem))
                {
                    error.Text = "The units should not be the same";
                    return;
                }
                double decUnit = Convert.ToDouble(fromUnit.SelectedValue);
                double prod = input * decUnit;
                double enUnit = Convert.ToDouble(toUnit.SelectedValue);
                double res = prod / enUnit;
                output.Text = Convert.ToString(res);
            }
            else
            {
                error.Text = "Make sure select your item in both dropdown lists";
            }
            return;
        }
        bool IsDigitsOnly(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                
      
                if (c == '.')
                {
                    count++;
                    if (count == 2) return false;
                    continue;
                }
                if (c < '0' || c > '9' )
                    return false;
            }
            return true;
        }
    }
}