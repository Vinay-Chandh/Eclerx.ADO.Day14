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
using System.Configuration;

namespace EClerx.ADO.Day14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Create Sql Connection
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString);

            //Create Sql Command - Select Query or DML Query or Stored Procedure
            cmd = new SqlCommand("Select cEmployeeCode, vFirstName, cCity, cState from Employee", con);

            //Open the connection
            con.Open();

            //Execute the command and fetch datas
            reader = cmd.ExecuteReader();

            //Read the first row
            reader.Read();

            //Store into releavant TextBoxes
            TxtEmpCode.Text = reader["cEmployeeCode"].ToString();
            TxtFirstName.Text = reader["vFirstName"].ToString();
            TxtCity.Text = reader["cCity"].ToString();
            TxtState.Text = reader["cState"].ToString();

            //Close the reader object
            reader.Close();

            //Dispose Command Object
            cmd.Dispose();

            //Close the connection
            con.Close();
        }

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            this.ClearText();
        }
        public void ClearText()
        {
            TxtEmpCode.Text = "";
            TxtFirstName.Clear();
            TxtCity.Text = "";
            TxtState.Text = "";
            TxtSocialSecurityNo.Text = "";
            TxtEmpCode.Focus();
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("Select vFirstName, cCity, cState, cSocialSecurityNo from Employee Where cEmployeeCode=@EmployeeCode", con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeCode", TxtEmpCode.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            TxtFirstName.Text = reader["vFirstName"].ToString();
                            TxtCity.Text = reader["cCity"].ToString();
                            TxtState.Text = reader["cState"].ToString();
                            TxtSocialSecurityNo.Text = reader["cSocialSecurityNo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No Record");
                            this.ClearText();
                        }
                    }
                }
            }
        }

        private void BtnAddNew_Click_1(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_AddNewEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeCode", TxtEmpCode.Text);
                    cmd.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
                    cmd.Parameters.AddWithValue("@City", TxtCity.Text);
                    cmd.Parameters.AddWithValue("@State", TxtState.Text);
                    cmd.Parameters.AddWithValue("@SocialSecurityNo", TxtSocialSecurityNo.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery(); //used for DML operation
                }
            }
            MessageBox.Show("New Employee Created");
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_UpdateCityAndStateByCode", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@City", TxtCity.Text);
                    cmd.Parameters.AddWithValue("@State", TxtState.Text);
                    cmd.Parameters.AddWithValue("@EmployeeCode", TxtEmpCode.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record updated successfully");
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_DeleteEmlopyee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeCode", TxtEmpCode.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record deleted successfully");
        }
    }
}