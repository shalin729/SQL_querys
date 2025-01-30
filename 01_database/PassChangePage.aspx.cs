using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;

    void MyConn()
    {
        conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|datadirectory|\\Database.mdf;Integrated Security=True");
        conn.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Request.Cookies["login"].Values["v2"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MyConn();
        cmd = new SqlCommand("Select * from Sqlpractice where Email=@Email and Password = @Password", conn);
        cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            MyConn();

            cmd = new SqlCommand("update  Sqlpractice set Password=@Password where Email=@Email", conn);
            cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
            da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            //conn.Close();

            Response.Write("Password change Successfully");
            Response.Redirect("page2.aspx");
            Session["msg"] = "Password changed";
            //Session.Remove("otp");
        }
        else
        {
            Response.Write("Email or old password is wrong");
        }
    }
}