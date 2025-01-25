using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MyConn();

        cmd = new SqlCommand("insert into Sqlpractice values(@Name,@Email,@Password,@PhNo)", conn);
        cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
        cmd.Parameters.AddWithValue("@PhNo", TextBox4.Text);

        cmd = new SqlCommand("Select * from Sqlpractice where Email=@Email", conn);
        cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        if (TextBox2.Text == ds.Tables[0].Rows[0]["Email"].ToString())
        {


            Response.Write("Exist");
        }
        else
        {
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("Data successfully added");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        MyConn();
        cmd = new SqlCommand("select * from Sqlpractice", conn);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        MyConn();

        cmd = new SqlCommand("select * from Sqlpractice where Name=@Name", conn);
        cmd.Parameters.AddWithValue("@Name", TextBox5.Text); 
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        MyConn();

        cmd = new SqlCommand("Delete from Sqlpractice where Name=@Name", conn);
        cmd.Parameters.AddWithValue("@Name", TextBox5.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds;
        //GridView1.DataBind();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        MyConn();

        cmd = new SqlCommand("Select * from Sqlpractice where Name=@Name", conn);
        cmd.Parameters.AddWithValue("@Name", TextBox5.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {


            TextBox1.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            TextBox2.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            TextBox3.Text = ds.Tables[0].Rows[0]["Password"].ToString();
            TextBox4.Text = ds.Tables[0].Rows[0]["PhNo"].ToString();
        }


    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        MyConn();
        
        cmd = new SqlCommand("Update Sqlpractice set Name=@newName,Email=@newEmail,Password=@newPassword,PhNo=@newPhNo  where Name=@Name", conn);
        cmd.Parameters.AddWithValue("@Name", TextBox5.Text);

        cmd.Parameters.AddWithValue("@newName", TextBox1.Text);
        cmd.Parameters.AddWithValue("@newEmail", TextBox2.Text);
        cmd.Parameters.AddWithValue("@newPassword", TextBox3.Text);
        cmd.Parameters.AddWithValue("@newPhNo", TextBox4.Text);

        cmd.ExecuteNonQuery();
        //conn.Close();

        Response.Write("Data Successfully Updated");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        MyConn();

        cmd = new SqlCommand("Select * from Sqlpractice where Email=@Email and Password=@Password", conn);
        cmd.Parameters.AddWithValue("@Email", TextBox6.Text);
        cmd.Parameters.AddWithValue("@Password", TextBox7.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        //GridView1.DataSource = ds;
        //GridView1.DataBind();
        if (ds.Tables[0].Rows.Count>0)
        {
            Response.Write("Log In Successfully");

            HttpCookie c1 = new HttpCookie("login");
            c1.Values.Add("v1", ds.Tables[0].Rows[0]["Name"].ToString());
            //c1.Values.Add("v2", ds.Tables[0].Rows[0]["Email"].ToString());
            //c1.Values.Add("v3", ds.Tables[0].Rows[0][""].ToString());
            //c1.Values.Add("v4", ds.Tables[0].Rows[0]["Email"].ToString());



            c1.Expires = System.DateTime.Now.AddDays(2);
            Response.Cookies.Add(c1);

            Response.Write("cookie created...");
            Response.Redirect("page2.aspx");
        }
        else
        {
            Response.Write("Ragester now");
        }
    }
}