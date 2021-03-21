using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationDatabase
{
    public partial class SearchJobs : Form
    {
        SqlConnection conn;
        SqlDataReader dbReader;
        SqlCommand command;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kevin Chucci\source\repos\JobApplicationDatabase\JobApplicationDatabase\Jobs.mdf;Integrated Security = True";
        public SearchJobs()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            errorMessage.Text = "";
            searchBar.Focus();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string sql, company, city, state, position, date;
            int id;
            errorMessage.Text = "";

            try
            {
                sql = "select id, company, city, state, position, date from applications where Company = '" + searchBar.Text + "'";
                command = new SqlCommand(sql, conn);
                conn.Open();
                dbReader = command.ExecuteReader();
                dbReader.Read();
                   
                if (dbReader.HasRows)
                {
                    id = dbReader.GetInt32(0);
                    company = dbReader.GetString(1);
                    city = dbReader.GetString(2);
                    state = dbReader.GetString(3);
                    position = dbReader.GetString(4);
                    date = dbReader.GetString(5);
                    searchBar.Text = "";

                    Information form = new Information(id, company, city, state, position, date);
                    form.ShowDialog();
                }
                else
                {
                    errorMessage.Text = "Company Not Found";
                    searchBar.Text = "";
                    searchBar.Focus();
                }

                conn.Close();
            }
                catch
            {

            }
        }
    }
}
