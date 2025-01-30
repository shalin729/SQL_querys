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
using System.ServiceModel.Channels;


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
        MyConn();
        cmd = new SqlCommand("select * from Sqlpractice where Email=@Email", conn);
        cmd.Parameters.AddWithValue("@Email", Session["email"].ToString());
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            TextBox2.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            //TextBox1.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            //TextBox3.Text = ds.Tables[0].Rows[0]["PhNo"].ToString();
        }
        else
        {
            Response.Write("No data found.");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MyConn();
        if (Session["email"] == null)
        {
            Response.Write("Error: No email found in session.");
        }
        else
        {
            Session.Remove("name");
            //cmd = new SqlCommand("Update Sqlpractice set PhNo=@newPhNo  where Name=@Name", conn);

        cmd = new SqlCommand("Update Sqlpractice set Name=@newName,PhNo=@newPhNo  where Email=@Email", conn);
        //cmd.Parameters.AddWithValue("@Email", Session["email"].ToString());
        cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
        cmd.Parameters.AddWithValue("@newName", TextBox1.Text);
        cmd.Parameters.AddWithValue("@newPhNo", TextBox3.Text);

        cmd.ExecuteNonQuery();
            //conn.Close();
        Response.Write("Data Successfully Updated");
    }

}
}