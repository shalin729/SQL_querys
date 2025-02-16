using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for dal
/// </summary>
public class connection
{
    public SqlConnection con;
    public SqlCommand cmd;
    public SqlDataAdapter da;
    public DataSet ds;

    public void myCon()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
        con.Open();
    }
}

public class registrationDAL:connection
{
    public int insert_registration(registrationBAL rBAL)
    {
        myCon();

        cmd = new SqlCommand("insert into rgistration values(@nm,@em,@ps)",con);
        cmd.Parameters.AddWithValue("@nm", rBAL.name);
        cmd.Parameters.AddWithValue("@em", rBAL.email);
        cmd.Parameters.AddWithValue("@ps", rBAL.password);
        cmd.ExecuteNonQuery();

        con.Close();
        return 1;

    }
    public DataSet view_data()
    {
        myCon();

        cmd = new SqlCommand("select * from rgistration", con);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        con.Close();

        return ds;

    }
}