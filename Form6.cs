using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab67
{
    public partial class Form6 : Form
    {
        private SqlConnection sqlConnection = null;
        private string c = @"Data Source=DESKTOP-BTK62TB;Initial Catalog=HOSPITAL;Integrated Security=True;MultipleActiveResultSets=true;";
        private string a = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report1 report1 = new Report1(sqlConnection,c);
            report1.WriteReport1();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(c);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select txtPatientSurname, txtPatientName,txtPatientSecondName from tblPatient", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                comboBox1.Items.Add(Convert.ToString(reader.GetString(0).Substring(0,8)) + Convert.ToString(reader.GetString(1).Substring(0, 10)) + Convert.ToString(reader.GetString(2).Substring(0, 13)));
            }

            reader.Close();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report2 report2 = new Report2(sqlConnection, c);
            report2.WriteReport1();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Report3 report3 = new Report3(c, comboBox1.Text);
            report3.WriteReport2();

        }
    }
}
