using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBEntry_Crud_lab
{
    public partial class INSERT_DETAILS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void subBtn_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.id = Convert.ToInt32(Textbox1.Text);
            emp.name = Textbox2.Text;
            emp.city = Textbox3.Text;
            emp.bod = Convert.ToDateTime(Textbox4.Text);
            //creatr connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BIRJU\source\repos\DBEntry_Crud_lab\DBEntry_Crud_lab\App_Data\Database1.mdf;Integrated Security=True;Connect Timeout=30";

            //create crud
            SqlCommand command = new SqlCommand();
            command.CommandText = $"INSERT INTO employee VALUES ('{emp.id}','{emp.name}','{emp.city}','{emp.bod.ToString("M-d-yyyy")}')";
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Response.Write("data inserted successfully!");

        }
    }
}