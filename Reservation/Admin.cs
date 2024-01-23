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

namespace Reservation
{
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(DBSQL.conString);

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        //Show all
        private void button4_Click(object sender, EventArgs e)
        {
            connect.Open();
            string script = @"SELECT * FROM Client";
            SqlCommand command = new SqlCommand(script, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string script = @"SELECT * FROM Client WHERE Name=@name";
            SqlCommand command = new SqlCommand(script, connect);
            command.Parameters.AddWithValue("@name", textBox1.Text.ToLower());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        public void Delete(int id)
        {
            connect.Open();
            string script = @"DELETE FROM Client WHERE ID=@id";
            SqlCommand command = new SqlCommand(script, connect);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Silindi");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);//1
                Delete(id);//1
            }
        }

        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            connect.Open();
            string script = @"UPDATE Client SET Status=@status WHERE ID=@id";
            SqlCommand command = new SqlCommand(script, connect);
            command.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);
            command.Parameters.AddWithValue("@status", comboBox1.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Redakte edildi");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
        }
    }
}
