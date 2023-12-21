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
    public partial class Form3 : Form
    {
        object data;
        object data2;
        object data3;

        private string c = @"Data Source=DESKTOP-BTK62TB;Initial Catalog=HOSPITAL;Integrated Security=True";
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
 

        public Form3(object data, object data2, object data3, string h)
        {
            InitializeComponent();

            this.data = data;
            this.data2 = data2;
            this.data3 = data3;
      

            richTextBox1.Text = data.ToString();
            richTextBox2.Text = data2.ToString();
            richTextBox3.Text = data3.ToString();
      

            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            richTextBox3.ReadOnly = true;
            
        }



        public void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hOSPITALDataSet.tblDoctor". При необходимости она может быть перемещена или удалена.
            this.tblDoctorTableAdapter.Fill(this.hOSPITALDataSet.tblDoctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hOSPITALDataSet.tblDoctor". При необходимости она может быть перемещена или удалена.
            this.tblDoctorTableAdapter.Fill(this.hOSPITALDataSet.tblDoctor);
            sqlConnection = new SqlConnection(c);
            sqlConnection.Open();
            richTextBox4.Visible = false;
            richTextBox5.Visible = false;

            adapter = new SqlDataAdapter("SELECT tblReception.datReceptionDate as 'Дата приема', " +
                "tblReception.txtReceptionTime as 'Время приема', tblReception.txtReceptionRoom as 'Номер кабинета', " +
 "tblPatient.txtPatientSurname as 'Фамилия пациента', tblReception.txtReceptionResult as Заключение FROM tblPatient, tblDoctor, tblReception WHERE " +
 "(tblPatient.intPatientId = tblReception.intPatientId) and (tblDoctor.txtDoctorName= '" + richTextBox1.Text + "') and (tblReception.intDoctorId = tblDoctor.intDoctorId)", sqlConnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
            SqlCommand command = new SqlCommand("SELECT intDoctorId  From tblDoctor where tblDoctor.txtDoctorName= '" + richTextBox1.Text + "' ", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                richTextBox4.Text = reader[0].ToString();
            }
            richTextBox4.ReadOnly = true;
            reader.Close();
            SqlCommand command1 = new SqlCommand("SELECT intPatientId FROM tblReception where tblReception.intDoctorId = '" + richTextBox4.Text + "' ", sqlConnection);
            SqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                richTextBox5.Text = reader1[0].ToString();
            }
            richTextBox5.ReadOnly = true;
            reader.Close();
            reader1.Close();
            string s = richTextBox4.Text;

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            
            object hell =  richTextBox1.Text;
            object hell2 = richTextBox2.Text;
            object s = richTextBox4.Text;
            Form5 form = new Form5(hell, hell2,s);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT tblReception.datReceptionDate as 'Дата приема', " +
               "tblReception.txtReceptionTime as 'Время приема', tblReception.txtReceptionRoom as 'Номер кабинета', " +
"tblPatient.txtPatientSurname as 'Фамилия пациента', tblReception.txtReceptionResult as Заключение FROM tblPatient, tblDoctor, tblReception WHERE " +
"(tblPatient.intPatientId = tblReception.intPatientId) and (tblDoctor.txtDoctorName= '" + richTextBox1.Text + "') and (tblReception.intDoctorId = tblDoctor.intDoctorId)", sqlConnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void richTextBox4_TextChanged_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT intDoctorId  From tblDoctorId where tblDoctor.txtDoctorName= '" + richTextBox1.Text + "' ", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                richTextBox4.Text = reader[1].ToString();
            }
            richTextBox4.ReadOnly = true;

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(c);
            sqlConnection.Open();

            adapter = new SqlDataAdapter("SELECT tblReception.datReceptionDate as 'Дата приема', " +
                "tblReception.txtReceptionTime as 'Время приема', tblReception.txtReceptionRoom as 'Номер кабинета', " +
 "tblPatient.txtPatientSurname as 'Фамилия пациента', tblReception.txtReceptionResult as Заключение FROM tblPatient, tblDoctor, tblReception WHERE " +
 "(tblPatient.intPatientId = tblReception.intPatientId) and (tblDoctor.txtDoctorName= '" + richTextBox1.Text + "') and (tblReception.intDoctorId = tblDoctor.intDoctorId)", sqlConnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
