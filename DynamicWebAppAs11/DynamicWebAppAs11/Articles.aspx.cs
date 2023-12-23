using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicWebAppAs11
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("server=DESKTOP-7E5H6QT;database=ContentDb;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("select * from Articles", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                LblMsg.Text = "number of Articles" + ds.Tables[0].Rows.Count;
                Grid.DataSource = ds.Tables[0];
                Grid.DataBind();
                con.Close();

            }
            catch (Exception ex)
            {
                LblMsg.Text = "error" + ex.Message;
            }
            finally { }
        }

        protected void GridArticle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

       