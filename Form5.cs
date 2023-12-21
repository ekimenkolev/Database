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


namespace lab67
{
    public partial class Form5 : Form
    {
        object data;
        object data2;
        string s;
        private DataTable table = null;

        private string c = @"Data Source=DESKTOP-BTK62TB;Initial Catalog=HOSPITAL;Integrated Security=True";
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        
        public Form5(object data, object data2, object s )
        {
            InitializeComponent();
             this.data = richTextBox1.Text;
             this.data2 = richTextBox2.Text;
            this.s = richTextBox3.Text;
            richTextBox1.Text = data.ToString();

            richTextBox2.Text = data2.ToString();
            richTextBox4.Text = s.ToString();
            richTextBox2.ReadOnly = true;
            richTextBox1.ReadOnly = true;
            richTextBox3.Text = comboBox1.Text;
            

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hOSPITALDataSet.tblReception". При необходимости она может быть перемещена или удалена.
            this.tblReceptionTableAdapter.Fill(this.hOSPITALDataSet.tblReception);
            sqlConnection = new SqlConnection(c);
            sqlConnection.Open();
            intDoctorIdTextBox.Visible = false;
            intPatientIdTextBox.Visible = false;
            txtReceptionRoomTextBox.Visible = false;
            richTextBox3.Visible = false;
            richTextBox4.Visible = false;
            List<object> Personal = new List<object>();

            

            sqlCommand = new SqlCommand("SELECT txtPatientSurname FROM tblPatient", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Personal.Add(reader.GetValue(0));

                }
            }

            foreach (var ob in Personal)
            {
                comboBox1.Items.Add(ob);
            }

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            reader.Close();
            txtReceptionRoomTextBox.Clear();
            txtReceptionTimeTextBox.Clear();
            txtReceptionResultTextBox.Clear();
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("45");
            comboBox2.Items.Add("54");
            comboBox2.Items.Add("64");
            comboBox2.Items.Add("17");
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void tblReceptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = comboBox1.Text;
            SqlCommand command = new SqlCommand("Select intPatientId from tblPatient where txtPatientSurname = '" + comboBox1.Text + "'", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                richTextBox3.Text = reader[0].ToString();
            }
            reader.Close();
            
            SqlCommand insert = new SqlCommand("INsert into tblReception( intDoctorId, intPatientId, " +
                "txtReceptionTime ,txtReceptionRoom,txtReceptionResult) " +
                "values('" + richTextBox4.Text + "', '" + richTextBox3.Text + "'," +
                "'" + txtReceptionTimeTextBox.Text + "','" + txtReceptionRoomTextBox.Text + "','" + txtReceptionResultTextBox.Text + "')", sqlConnection);
            try
            {
                await insert.ExecuteNonQueryAsync();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Validate();
            this.tblReceptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOSPITALDataSet);
            this.Close();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = comboBox1.Text;
            txtReceptionRoomTextBox.Text = comboBox2.Text;
            SqlCommand command = new SqlCommand("Select intPatientId from tblPatient where txtPatientSurname = '" + comboBox1.Text + "'", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                richTextBox3.Text = reader[0].ToString();
            }
            reader.Close();
            SqlCommand command1 = new SqlCommand("Select intDoctorId from tblDoctor where txtDoctorName = '" + richTextBox1.Text + "'", sqlConnection);
            SqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                richTextBox4.Text = reader1[0].ToString();
            }
            reader1.Close();
            intDoctorIdTextBox.Text = richTextBox4.Text;
            intPatientIdTextBox.Text = richTextBox3.Text;
            this.Validate();
            this.tblReceptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOSPITALDataSet);
            txtReceptionRoomTextBox.Clear();
            txtReceptionTimeTextBox.Clear();
            txtReceptionResultTextBox.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datReceptionDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tblReceptionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tblReceptionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblReceptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOSPITALDataSet);

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void intPatientIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
