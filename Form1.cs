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
    public partial class Form1 : Form
    {

        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        private List<string> artistId;

        private string c = @"Data Source=DESKTOP-BTK62TB;Initial Catalog=HOSPITAL;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hOSPITALDataSet.tblDoctor". При необходимости она может быть перемещена или удалена.
            this.tblDoctorTableAdapter.Fill(this.hOSPITALDataSet.tblDoctor);
            sqlConnection = new SqlConnection(c);
            sqlConnection.Open();
            SqlDataReader sqlReader = null;
            richTextBox1.Visible = false;
            artistId = new List<string>();

            adapter = new SqlDataAdapter("SELECT txtDoctorName AS 'ФИО Доктора'," +
            "txtSpecialist AS Специальность,datDoctorWork AS 'Дата приема на " +
            "работу' FROM tblDoctor", sqlConnection);

            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private async Task LoadArtistsAsync()
        {
            artistId = new List<string>();
            SqlDataReader sqlReader = null;

            SqlCommand getArtistsCommand = new SqlCommand("select intDoctorId From tblDoctor", sqlConnection);
            try
            {
                sqlReader = await getArtistsCommand.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    artistId.Add(Convert.ToString(sqlReader["intDoctorId"]).Trim(' '));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }
        }



        public void tblDoctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOSPITALDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            table.Clear();

            this.tblDoctorTableAdapter.Fill(this.hOSPITALDataSet.tblDoctor);
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BTK62TB;Initial Catalog=HOSPITAL;Integrated Security=True");
            sqlConnection.Open();

            adapter = new SqlDataAdapter("SELECT txtDoctorName AS 'ФИО Доктора',txtSpecialist " +
                "AS Специальность,datDoctorWork AS 'Дата приема на работу' FROM tblDoctor", sqlConnection);
            
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                object hell = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                object hell2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                object hell3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value;



                SqlCommand command = new SqlCommand("SELECT * FROM tblDoctor", sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (hell.ToString() == reader[1].ToString())
                    {
                        c = reader[0].ToString();
                        break;
                    }
                }

                reader.Close();



                reader.Close();

                Form3 newForm = new Form3 (hell, hell2, hell3, c);
                newForm.Show();
                this.Opacity = 1;
                this.ShowInTaskbar = true;
            }

        }
    }
}


