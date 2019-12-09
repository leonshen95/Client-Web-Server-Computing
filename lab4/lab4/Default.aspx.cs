using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4
{
    
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9' || c =='-')
                    return false;
            }
            return true;
        }
        bool Reversecheck(string str)
        {
            string str2 = new string(str.Reverse().ToArray());
            if (str == str2) return true;
            else return false;
        }
        bool CheckOverFlow(string str)
        {
            int i = 0, bas = 0;
            while(i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                if(bas > Int32.MaxValue/10 || (bas == Int32.MaxValue/10 && str[i]-'0' > 7)){
                    return false;
                }
                bas = 10 * bas + (str[i++] - '0');
            }
            return true;
        }
        protected void Generate_Click(object sender, EventArgs e)
        {
            Result.Items.Clear();
            if(Num.Text == "" || Start.Text == "" || IsDigitsOnly(Num.Text) == false || IsDigitsOnly(Start.Text) == false || CheckOverFlow(Start.Text) == false)
            {
                Comment.Text = "Please enter a postive interger within range";
                return;
            }
            int num = Convert.ToInt32(Num.Text);
            int start = Convert.ToInt32(Start.Text);
            if(start < 0 || start > 1000000000)
            {
                Comment.Text = "Please enter a postive interger within range";
                return;
            }
            int count = 0;
            while(count < num)
            {
                string test = start.ToString();
                if(Reversecheck(test) == true)
                {
                    Result.Items.Add(test);
                    count++;
                }
                start++;
            }
            
        }
    }
}