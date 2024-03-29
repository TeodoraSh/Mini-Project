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


namespace store
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC09\SQLEXPRESS; Initial Catalog=store; Integrated Security=True;"))
                {
                    sqlCon.Open();
                    string insertQuery = "INSERT INTO booking (firstName, lastName, email ) VALUES (@firstName, @lastName, @email)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);
                    insertCmd.Parameters.AddWithValue("@firstName", textBox1.Text);
                    insertCmd.Parameters.AddWithValue("@lastName", textBox2.Text);
                    insertCmd.Parameters.AddWithValue("@email", textBox3.Text);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


    }
}
