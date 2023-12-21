using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab67
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tblDoctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOSPITALDataSet);
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hOSPITALDataSet.tblDoctor". При необходимости она может быть перемещена или удалена.
            this.tblDoctorTableAdapter.Fill(this.hOSPITALDataSet.tblDoctor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtDoctorNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void datDoctorWorkLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
