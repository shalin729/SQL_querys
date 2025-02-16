using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        registrationBAL rBAL = new registrationBAL();
        rBAL.name = TextBox1.Text;
        rBAL.email = TextBox2.Text;
        rBAL.password = TextBox3.Text;

        registrationDAL rDal = new registrationDAL();
        int rval = rDal.insert_registration(rBAL);
        if (rval == 1)
        {

        Response.Write("Data successfully added");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        registrationDAL rDAL = new registrationDAL();
        DataSet ds = rDAL.view_data();
        if (ds != null)
        {

            Repeater1.DataSource =ds;
            Repeater1.DataBind();
        }
    }
}