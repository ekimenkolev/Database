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
using System.IO;
using System.Diagnostics;

namespace lab67
{
    class Report3
    {
        private readonly SqlConnection connect = null;
        string patientName = null;
        public Report3(string s, string str)
        {
            connect = new SqlConnection(s);
            patientName = str;
            connect.Open();
        }
        public void WriteReport2()
        {
            string pat = patientName;
            StreamWriter f = new StreamWriter("report3.html");
            f.WriteLine("<h1 style='text-align: center;'>Работа поликлиники</h1>");
            f.WriteLine("<div style='text-align: center'>");
            f.WriteLine("<p ФИО Пациента: >" + pat + "</p");
            SqlCommand com1 = new SqlCommand(
               "select  datBirthday,txtAddress from tblPatient where (txtPatientSurname = '"+ pat.Split(' ')[0] + "')  ", connect);
            SqlDataReader reader0 = com1.ExecuteReader();

            while (reader0.Read())
            {
                f.WriteLine("<p>День рождения: " + reader0.GetDateTime(0).ToString("dd.MM.yyyy") + " </p>");
                f.WriteLine("<p>Адрес: " + reader0.GetValue(1) + " </p>");

                SqlCommand command = new SqlCommand(
               "select datReceptionDate,txtReceptionTime, txtDoctorName, txtSpecialist,txtReceptionResult from tblDoctor, tblReception, tblPatient where " +
               "(tblReception.intDoctorId = tblDoctor.intDoctorId) and (tblReception.intPatientId = tblPatient.intPatientId) " +
               "and (tblPatient.txtPatientSurname = '" + pat.Split(' ')[0] + "') order by datReceptionDate DESC  ", connect);
                f.WriteLine("<table width=1000 align='center' border='1'> ");
                f.WriteLine("<tr width = 1000> <th width = 200 >Дата приема</th> <th width = 200 >" +
                           "Время приема</th> <th width = 200>ФИО Врача</th> <th width = 200>Специальность</th> <th width = 200>Заключение</th> " +
                           "</tr> ");
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    f.WriteLine("<table width=1000 align='center' border='1'> ");
                    f.WriteLine("<tr>");
                    f.WriteLine("<th width = 200> " + reader.GetDateTime(0).ToString("dd.MM.yyyy") + " </th>");
                    f.WriteLine("<th width = 200> " + reader.GetValue(1) + " </th>");
                    f.WriteLine("<th width = 200> " + reader.GetValue(2) + " </th>");
                    f.WriteLine("<th width = 200> " + reader.GetValue(3) + " </th>");
                    f.WriteLine("<th width = 200> " + reader.GetValue(4) + " </th>");
                    f.WriteLine("</tr>");
                }
                f.WriteLine("</table>");
                f.WriteLine("</table>");
                reader.Close();


            }
            reader0.Close();
            f.Close();
            Process.Start(@"report3.html");
        }
    }
}

