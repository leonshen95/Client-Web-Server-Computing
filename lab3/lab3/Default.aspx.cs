using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab3
{
    public partial class Default : System.Web.UI.Page
    {
        double a;
        double b; 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnAdd(object sender, EventArgs e)
        {
            error.Text = "";
            if (op1.Text == "" || op2.Text =="" || IsDigitsOnly(op1.Text) == false)
            {
                error.Text = "Invalid or Empty input";
                return;
            }
            a = Convert.ToDouble(op1.Text);
            op1.Text = "";
            b = Convert.ToDouble(op2.Text);
            op2.Text = (a + b).ToString();
        }

        protected void OnEnter(object sender, EventArgs e)
        {
            error.Text = "";
            if (op1.Text == "" || IsDigitsOnly(op1.Text) == false)
            {
                error.Text = "Invalid or Empty input";
                return;
            }
            a = Convert.ToDouble(op1.Text);
            op1.Text = "";
            op2.Text = a.ToString();
        }

        protected void OnSub(object sender, EventArgs e)
        {
            error.Text = "";
            if (op1.Text == "" || op2.Text == "" || IsDigitsOnly(op1.Text) == false)
            {
                error.Text = "Invalid or Empty input";
                return;
            }
            a = Convert.ToDouble(op1.Text);
            op1.Text = "";
            b = Convert.ToDouble(op2.Text);
            op2.Text = (b - a).ToString();
        }

        protected void OnMul(object sender, EventArgs e)
        {
            error.Text = "";
            if (op1.Text == "" || op2.Text == "" || IsDigitsOnly(op1.Text) == false)
            {
                error.Text = "Invalid or Empty input";
                return;
            }
            a = Convert.ToDouble(op1.Text);
            op1.Text = "";
            b = Convert.ToDouble(op2.Text);
            op2.Text = (b * a).ToString();
        }

        protected void OnDiv(object sender, EventArgs e)
        {
            error.Text = "";
            if (op1.Text == "" || op2.Text == "" || IsDigitsOnly(op1.Text) == false)
            {
                error.Text = "Invalid or Empty input";
                return;
            }
            a = Convert.ToDouble(op1.Text);
            op1.Text = "";
            b = Convert.ToDouble(op2.Text);


            if (a == 0)
            {
                error.Text = "Error: Argument 'divisor' is 0";
                return;
            }
            
            op2.Text = (b / a).ToString();
        }
        bool IsDigitsOnly(string str)
        {
            if(str[0] == '-')
            {
                str = str.Substring(1);
            }
            str = str.Replace(@".","");
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}