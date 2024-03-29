using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default values for ComboBoxes when the form is loaded
            colour.SelectedIndex = 0;
            style.SelectedIndex = 0;
            size.SelectedIndex = 0;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC09\SQLEXPRESS; Initial Catalog=store; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM coats WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (colour.SelectedItem != null)
                    conditions.Add("colour = @colour");

                if (style.SelectedItem != null)
                    conditions.Add("style = @style");

                if (size.SelectedItem != null)
                    conditions.Add("size = @size");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                cmd.Parameters.AddWithValue("@colour", colour.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@style", style.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@size", size.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            colour.SelectedIndex = 0;
            style.SelectedIndex = 0;
            size.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form2 Form2 = new Form2())
            {
                Form2.ShowDialog();
            }
        }
    }
}