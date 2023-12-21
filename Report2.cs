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
    class Report2
    {
        private readonly SqlConnection connect = null;
        int receptionCount = 0;
        int countDrugcErius = 0;
        int countDrugKreon = 0;
        int countDrugSis = 0;
        int countDrugVenarius = 0;
        int countDrug = 0;





        public Report2(SqlConnection sqlConnection, string s)
        {
            connect = new SqlConnection(s);
            connect.Open();
        }

        public void WriteReport1()
        {
            StreamWriter f = new StreamWriter("report2.html");
            f.WriteLine("<h1 style='text-align: center;'>Рецепты</h1>");
            f.WriteLine("<div style='text-align: center'>");
            f.WriteLine("<table width=1000 align='center' border='1'> ");

            SqlCommand com1 = new SqlCommand(
               "select  txtDoctorName, txtSpecialist,datDoctorWork, intDoctorId from tblDoctor ", connect);
            SqlDataReader reader0 = com1.ExecuteReader();
            
            while (reader0.Read())
            {
                f.WriteLine("<br> </br");
                f.WriteLine("<table width=1000 align='center' border='1'> ");
                f.WriteLine("<p>ФИО Доктора: " + reader0.GetValue(0) + " </p>");
                f.WriteLine("<p>Специальность: " + reader0.GetValue(1) + " </p>");
                f.WriteLine("<p>Дата приема на работу: " +
                    reader0.GetDateTime(2).ToString("dd.MM.yyyy") + " </p>");
                int n = reader0.GetInt32(3);
                //int intPatientId = reader0.GetInt32(4);

                SqlCommand command = new SqlCommand("select DISTINCT txtDrugName, txtDrugDescription,fltDrugPrice, " +
                    "tblDrug.intDrugId from tblDrug,tblDoctor,tblRecipe where (tblDrug.intDrugId = tblRecipe.intDrugId) " +
                    "and (tblRecipe.intDoctorId = tblDoctor.intDoctorId) and (txtDoctorName = '" + reader0.GetValue(0).ToString() + "')  ", connect);
                SqlDataReader reader = command.ExecuteReader();
                f.WriteLine("<table width=1000 align='center' border='1'> ");
                string stringDrugErius = "Эриус               ";
                string stringDrugKreon = "Креон               ";
                string stringDrugSis = "Систейн Ультра Плюс ";
                string stringDrugVenarius = "Венариус            ";

                

                while (reader.Read())
                {

                    f.WriteLine("<br> </br>");
                    f.WriteLine("<tr width=1000>");
                    f.WriteLine("<table width=1000 align='center' border='1'> ");
                    f.WriteLine("<th width = 333>" + reader.GetValue(0) + "</th>");
                    f.WriteLine("<th width = 333>" + reader.GetValue(1) + "</th>");
                    f.WriteLine("<th width = 333>" + reader.GetValue(2) + "</th>");
                    int intDrugId = reader.GetInt32(3);
                    f.WriteLine("</table>");
                    f.WriteLine("<br> </br>");

                    SqlCommand command1 = new SqlCommand("select datRecipeDate,txtPatientSurname,txtPatientSecondName," +
                    "txtPatientName,tblPatient.datBirthday,txtAddress,txtRecipeComment  from tblPatient, tblRecipe where ( tblRecipe.intDoctorId = '" + n + "')" +
                    " and(tblRecipe.intPatientId = tblPatient.intPatientId)  and (tblRecipe.intDrugId = '" + intDrugId + "')   ", connect);
                    SqlDataReader reader2 = command1.ExecuteReader();
                    f.WriteLine("<table width=1000 align='center' border='1'> ");
                    f.WriteLine("<tr width = 1000> <th width = 142 >Дата выписки рецепта</th> <th width = 142 >" +
                            "Фамилия</th> <th width = 142>Отчество</th> <th width = 142>Имя</th> <th width = 142>День рождения</th> " +
                            " <th width = 142> Адрес</th> <th width = 142> Описние </th>  </tr> ");
                    
                    while (reader2.Read())
                    {
                        if (stringDrugErius == reader.GetValue(0).ToString())
                        {
                            countDrugcErius++;
                           
                        }
                        else if (stringDrugVenarius == reader.GetValue(0).ToString())
                        {
                            
                            countDrugVenarius++;
                        }
                        else if (stringDrugSis == reader.GetValue(0).ToString())
                        {
                            countDrugSis++;
                        }
                        else if (stringDrugKreon == reader.GetValue(0).ToString())
                        {
                            countDrugKreon++;
                        }
                        
                        f.WriteLine("<table width=1000 align='center' border='1'> ");
                        f.WriteLine("<tr>");
                        f.WriteLine("<th width = 142> " + reader2.GetDateTime(0).ToString("dd.MM.yyyy") + "</p>");
                        f.WriteLine("<th width = 142>  " + reader2.GetValue(1) + "</th>");
                        f.WriteLine("<th width = 142> " + reader2.GetValue(2) + "</th>");
                        f.WriteLine("<th width = 142>  " + reader2.GetValue(3) + "</th>");
                        f.WriteLine("<th width = 142>  " + reader2.GetDateTime(4).ToString("dd.MM.yyyy") + " </th>");
                        f.WriteLine("<th width = 142> " + reader2.GetValue(5) + "</th>");
                        f.WriteLine("<th width = 142> " + reader2.GetValue(6) + "</th>");
                        f.WriteLine("</tr>");

                        
                    }
                        f.WriteLine("</table>");
                    reader2.Close();

                }
                

                reader.Close();

            }
            f.WriteLine("</table>");
            f.WriteLine("<br> </br>");
            f.WriteLine("<br> </br>");
       

            f.WriteLine("<table>");
            f.WriteLine("<table width=1000 align='center' border='1'> ");
            f.WriteLine("<tr> <th width = 250>Венариус</th> <th width = 250>Креон </th>  " +
                "<th width = 250>Эриус</th> <th width = 250>Систейн Ультра Плюс</th> </tr>");
            f.WriteLine("</tr>");
            SqlCommand command2 = new SqlCommand("select Count(tblRecipe.intDrugId )  from tblRecipe,tblDrug " +
                "where ( tblDrug.intDrugId = tblRecipe.intDrugId) GROUP BY txtDrugName ", connect);
            SqlDataReader reader3 = command2.ExecuteReader();
            f.WriteLine("<p> Количество рецептов по лекарству</p>");
            f.WriteLine("<table width=1000 align='center' border='1'> ");
            f.WriteLine("<tr>");
            
            while (reader3.Read())
            {
                
                f.WriteLine("<th width = 250>" +reader3.GetValue(0) + "</th>");
                
            }
            f.WriteLine("</tr>");
            f.WriteLine("</table>");
            f.WriteLine("</table>");

            f.WriteLine("<br> </br>");
            f.WriteLine("<br> </br>");
            SqlCommand command4 = new SqlCommand("select txtDoctorName from tblDoctor " +
            " Order by txtDoctorName ASC  ", connect);
            SqlDataReader reader5 = command4.ExecuteReader();
            f.WriteLine("<table width=1000 align='center' border='1'> ");
            f.WriteLine("<tr>");
            while (reader5.Read())
            {

                f.WriteLine("<th width = 111>" + reader5.GetValue(0) + "</th>");

            }
            reader5.Close();

            SqlCommand command3 = new SqlCommand("select  txtDoctorName ,sum(fltDrugPrice) from tblDrug, tblDoctor " +
                "RIGHT JOIN tblRecipe On (tblDoctor.intDoctorId = tblRecipe.intDoctorId) " +
                "RIGHT JOIN tblPatient On  (tblPatient.intPatientId = tblRecipe.intPatientId) where (tblRecipe.intDrugId = tblDrug.intDrugId)  GROUP BY txtDoctorName Order by txtDoctorName ASC  ", connect);
            SqlDataReader reader4 = command3.ExecuteReader();
            f.WriteLine("<p>Cуммарная стоимость выписанных рецептов для каждого врача</p>");
            f.WriteLine("<table width=1000 align='center' border='1'> ");
            f.WriteLine("<tr>");
            while (reader4.Read())
            {
                
                f.WriteLine("<th width = 111>" + reader4.GetValue(1) + "</th>");

            }
            reader4.Close();

            reader0.Close();
            string a = "11";
            f.WriteLine("<p>" + a + "</p>");
            f.Close();
            Process.Start(@"report2.html");
        }
    }
}


