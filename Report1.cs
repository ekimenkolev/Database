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
    class Report1 
    { 
        private readonly SqlConnection connect = null;
        int receptionCount = 0;
        


        public Report1(SqlConnection sqlConnection, string s )
        {
            connect = new SqlConnection(s);
            connect.Open();
        }

        public void WriteReport1()
        {
            StreamWriter f = new StreamWriter("report1.html");
            f.WriteLine("<h1 style='text-align: center;'>Работа поликлиники</h1>");
            f.WriteLine("<div style='text-align: center'>");

            SqlCommand com1 = new SqlCommand(
               "select datReceptionDate from tblReception GROUP BY datReceptionDate", connect);
            SqlDataReader reader0 = com1.ExecuteReader();
            f.WriteLine("<table width=650 align='center' border='1'> ");
            while (reader0.Read())
            {
                f.WriteLine("<table width=650 align='center' border='1'> ");
                f.WriteLine("<p>Дата приема:</u> " + reader0.GetDateTime(0).ToString("dd.MM.yyyy") + " </p>");
                f.WriteLine("<tr> <th>Время приема</th> <th>Номера кабинета</th> <th>ФИО врача</th> " +
                    "<th>Специальность</th> <th>Фамилия пациента</th>  </tr> ");
                var date = reader0.GetDateTime(0);

                
                SqlCommand command = new SqlCommand(
          "select txtReceptionTime, txtReceptionRoom, txtDoctorName, " +
          "txtSpecialist,txtPatientSurname, datReceptionDate from tblPatient, tblReception, tblDoctor " +
          "where (tblDoctor.intDoctorId = tblReception.intDoctorId) and (tblPatient.intPatientId = tblReception.intPatientId) and (datReceptionDate ='"+date+ "')    ", connect);
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    receptionCount++;
                    f.WriteLine("<tr>");
                    f.WriteLine("<td>" + reader.GetString(0) + "</td>");
                    f.WriteLine("<td>" + reader.GetString(1) + "</td>");
                    f.WriteLine("<td>" + reader.GetString(2) + "</td>");
                    f.WriteLine("<td>" + reader.GetString(3) + "</td>");
                    f.WriteLine("<td>" + reader.GetString(4) + "</td>");


                    f.WriteLine("</tr>");
                }
                reader.Close();
                
            }
            f.WriteLine("</table>");
            f.WriteLine("<br> </br>");
            f.WriteLine("<td> Суммарное количество приемов: " + receptionCount + "</td>");
            reader0.Close();
            f.Close();
            Process.Start(@"report1.html");
        }
    }
}
