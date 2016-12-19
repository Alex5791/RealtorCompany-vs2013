using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BCompany
{
    public partial class Form5 : Form
    {
        public DataTable tb2;
        public SqlConnection connection;
        public SqlCommand command;
        public string Nid;
        public Form5(DataTable tb2, SqlConnection connection, string Nid)
        {
            this.Nid = Nid;
            InitializeComponent();
            this.tb2 = tb2;
            this.connection = connection;
           
        }

        //Кнопка обновления/добавления объявления, если переданное (из textbox) значение пустая строка,
        //то вызывает процедуру добавления объявления, иначе вызывает процедуру изменения объявления
        //где, значение переданное из textbox приравниванием к номеру объявления (N) 
        private void button1_Click(object sender, EventArgs e)
        {
             if (Nid == "")
            {
                SqlCommand command = new SqlCommand("AddHouse", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Район", textBox1.Text);
                command.Parameters.AddWithValue("@Улица", textBox2.Text);
                command.Parameters.AddWithValue("@Дом", textBox3.Text);
                command.Parameters.AddWithValue("@Этажей", textBox4.Text);
                command.Parameters.AddWithValue("@Комнат", textBox5.Text);
                command.Parameters.AddWithValue("@Площадь", textBox6.Text);
                command.Parameters.AddWithValue("@Тип_объявления", textBox7.Text);
                command.Parameters.AddWithValue("@Цена", textBox8.Text);
                command.Parameters.AddWithValue("@Дата", textBox9.Text);
                command.Parameters.AddWithValue("@Статус", textBox10.Text);

                DataRow nr1 = tb2.NewRow();
                nr1["Район"] = textBox1.Text;
                nr1["Улица"] = textBox2.Text;
                nr1["Дом"] = textBox3.Text;
                nr1["Этажей"] = textBox4.Text;
                nr1["Комнат"] = textBox5.Text;
                nr1["Площадь"] = textBox6.Text;
                nr1["Тип_объявления"] = textBox7.Text;
                nr1["Цена"] = textBox8.Text;
                nr1["Дата"] = textBox9.Text;
                nr1["Статус"] = textBox10.Text;
                tb2.Rows.Add(nr1);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
             else
            {
                SqlCommand command = new SqlCommand("UpdateHouse", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@N", Nid);
                command.Parameters.AddWithValue("@Район", textBox1.Text);
                command.Parameters.AddWithValue("@Улица", textBox2.Text);
                command.Parameters.AddWithValue("@Дом", textBox3.Text);
                command.Parameters.AddWithValue("@Этажей", textBox4.Text);
                command.Parameters.AddWithValue("@Комнат", textBox5.Text);
                command.Parameters.AddWithValue("@Площадь", textBox6.Text);
                command.Parameters.AddWithValue("@Тип_объявления", textBox7.Text);
                command.Parameters.AddWithValue("@Цена", textBox8.Text);
                command.Parameters.AddWithValue("@Дата", textBox9.Text);
                command.Parameters.AddWithValue("@Статус", textBox10.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }
    }
}
