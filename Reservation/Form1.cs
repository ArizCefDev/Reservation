using System.Data.SqlClient;

namespace Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(DBSQL.conString);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            int price = 30;
            int day = Convert.ToInt32(textBox4.Text);
            int total = price * day;
            textBox8.Text = total.ToString();
            string script = @"INSERT INTO Client(Name, Surname, Tel, Person, Day, Date, Floor, Room, CardNo, Price, Status)
                                         VALUES (@name, @surname, @tel, @person, @day, @date, @floor, @room, @cardno, @price, @status)";
            SqlCommand command = new SqlCommand(script,connect);
            command.Parameters.AddWithValue("@name", textBox1.Text);
            command.Parameters.AddWithValue("@surname", textBox2.Text);
            command.Parameters.AddWithValue("@tel", textBox3.Text);
            command.Parameters.AddWithValue("@person", textBox6.Text);
            command.Parameters.AddWithValue("@day", textBox4.Text);
            command.Parameters.AddWithValue("@date", textBox5.Text);
            command.Parameters.AddWithValue("@floor", comboBox1.Text);
            command.Parameters.AddWithValue("@room", comboBox2.Text);
            command.Parameters.AddWithValue("@cardno", textBox7.Text);
            command.Parameters.AddWithValue("@price", textBox8.Text);
            command.Parameters.AddWithValue("@status", textBox9.Text);
            command.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Ugurla rezervasiya edildi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login next = new Login();
            next.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int price = 30;
            int day = Convert.ToInt32(textBox4.Text);
            int total = price * day;
            label10.Text = $"Mebleginiz : {total.ToString()} azn";
        }
    }
}