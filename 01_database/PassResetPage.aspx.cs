using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PassResetPage : System.Web.UI.Page
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

        //cmd = new SqlCommand("insert into Sqlpractice values(@Name,@Email,@Password,@PhNo)", conn);
        //cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
        //cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
        //cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
        //cmd.Parameters.AddWithValue("@PhNo", TextBox4.Text);

        cmd = new SqlCommand("Select * from Sqlpractice where Email=@Email", conn);
        cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        //GridView1.DataSource = ds;
        //GridView1.DataBind();
        if (TextBox1.Text == ds.Tables[0].Rows[0]["Email"].ToString())
        {
            Random r = new Random();
            string otp = r.Next(1000, 9999).ToString();

            string message = "You otp for reset password <br>Your OTP=" + otp;

            if (GmailSender.SendMail("xipratestmail@gmail.com", "murp ipqn zohd harr", TextBox1.Text, "Your OTP", message))
            {
                Response.Write("Password Reset otp has been successfully sent on your email account");
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                //TextBox4.Enabled = true;
            }
            else
            {

                Response.Write("pls chk you internet connection message sending fail");
            }
            
        }
        else
        {
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Response.Write("Data successfully added");
        }

           
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if(TextBox2.Text == TextBox4.Text)
        {
            MyConn();
            cmd = new SqlCommand("update  Sqlpractice set Password=@Password where Email=@Email", conn);
            cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
            da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            //conn.Close();

            Response.Write("Data Successfully Updated");
        }
    }
}