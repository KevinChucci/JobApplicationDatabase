using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobApplicationDatabase
{
    
    public partial class Home : Form
    {
        SqlConnection conn;
        SqlDataReader dbReader;
        SqlCommand command;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kevin Chucci\source\repos\JobApplicationDatabase\JobApplicationDatabase\Jobs.mdf;Integrated Security = True";

        public Home()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            errorMessage.Text = "";
        }

        private void addJob_Click(object sender, EventArgs e)
        {
            AddJob form = new AddJob();
            form.ShowDialog();
            //try
            //{
            //    string sql = "select Company from applications";
            //    command = new SqlCommand(sql, conn);
            //    conn.Open();
            //    dbReader = command.ExecuteReader();
            //    dbReader.Read();

            //    if (dbReader.HasRows)
            //    {
            //        addJob.Text = dbReader.GetString(0);
            //        conn.Close();
            //    }
            //}
            //catch
            //{
            //    errorMessage.Text = "Connection Failed";
            //}
            
        }
    }
}
