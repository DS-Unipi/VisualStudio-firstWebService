using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCallWS_Click(object sender, EventArgs e) {
        ServiceReference1.MathOperationsClient moc = new ServiceReference1.MathOperationsClient();
        ServiceReference1.MathsValues mv = new ServiceReference1.MathsValues();
        mv.Number1 = Int32.Parse(tbNumber1.Text);
        mv.Number2 = Int32.Parse(tbNumber2.Text);
        int res = 0;
        switch (ddlOperation.SelectedValue)
        {
            case "add":
                res = moc.Addition(mv);
                break;
            case "sub":
                res = moc.Subtraction(mv);
                break;
            case "mul":
                res = moc.Multiplication(mv);
                break;
            case "div":
                res = moc.Division(mv);
                break;
        }

        lblResult.Text = res.ToString();
    }

}