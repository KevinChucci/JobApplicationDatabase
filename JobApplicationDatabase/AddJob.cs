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
    public partial class AddJob : Form
    {
        SqlConnection conn;
        SqlDataReader dbReader;
        SqlCommand command;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kevin Chucci\source\repos\JobApplicationDatabase\JobApplicationDatabase\Jobs.mdf;Integrated Security = True";

        public AddJob()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            errorMessage.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int id;
            string sqlInsert, sqlSelect;
            errorMessage.Text = "";

            try
            {
                sqlSelect = "select max(Id) from applications";
                command = new SqlCommand(sqlSelect, conn);
                conn.Open();
                dbReader = command.ExecuteReader();
                dbReader.Read();

                id = dbReader.GetInt32(0) + 1;

                conn.Close();

                if (companyName.Text == "" || cityName.Text == "" || positionName.Text == "")
                {
                    errorMessage.Text = "Required Fields Have Been Left Blank";
                }
                else
                {
                    if (stateName.Text == "")
                    {
                        sqlInsert = "insert into applications (Id, Company, City, State, Position, Date) ";
                        sqlInsert += "values (" + id + ",'" + companyName.Text + "','" + cityName.Text + "', NULL, '" + positionName.Text + "', '" + dateApplied.Value.ToString() + "')";
                        command = new SqlCommand(sqlInsert, conn);
                        conn.Open();
                        Console.WriteLine(sqlInsert);
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        sqlInsert = "insert into applications (Id, Company, City, State, Position, Date) ";
                        sqlInsert += "values (" + id + ",'" + companyName.Text + "','" + cityName.Text + "','" + stateName.Text + "','" + positionName.Text + "', '" + dateApplied.Value.ToString() + "')";
                        command = new SqlCommand(sqlInsert, conn);
                        conn.Open();
                        Console.WriteLine(sqlInsert);
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                
            }
            catch
            {
                errorMessage.Text = "ERROR";
            }
            finally
            {
                companyName.Text = "";
                cityName.Text = "";
                stateName.Text = "";
                positionName.Text = "";
            }
        }
    }
}
