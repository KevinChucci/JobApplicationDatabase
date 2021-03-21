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
    public partial class Information : Form
    {
        SqlConnection conn;
        SqlCommand command;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kevin Chucci\source\repos\JobApplicationDatabase\JobApplicationDatabase\Jobs.mdf;Integrated Security = True";

        public Information(int id, string company, string city, string state, string position, string date)
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            idNum.Text = id.ToString();
            companyName.Text = company;
            cityName.Text = city;
            stateName.Text = state;
            positionName.Text = position;
            dateApplied.Text = date;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            save_button.Visible = true;
            companyName.ReadOnly = false;
            cityName.ReadOnly = false;
            stateName.ReadOnly = false;
            positionName.ReadOnly = false;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            save_button.Visible = false;
            companyName.ReadOnly = true;
            cityName.ReadOnly = true;
            stateName.ReadOnly = true;
            positionName.ReadOnly = true;

            string sqlUpdate = "update applications set company = '" + companyName.Text + "', city = '" + cityName.Text + "', state = '" + stateName.Text + "', position = '" + positionName.Text + "'";
            sqlUpdate += " where id = " + idNum.Text;
            Console.WriteLine(sqlUpdate);
            command = new SqlCommand(sqlUpdate, conn);
            conn.Open();
            command.ExecuteNonQuery();

        }
    }
}
