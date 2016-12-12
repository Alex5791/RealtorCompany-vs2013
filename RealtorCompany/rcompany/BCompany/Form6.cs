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
    public partial class Form6 : Form
    {
        public DataTable tb3;
        public SqlConnection connection;
        public SqlCommand command;
        public Form6(DataTable tb3, SqlConnection connection)
        {
            InitializeComponent();
            this.tb3 = tb3;
            this.connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("AddOffice", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Район", textBox1.Text);
            command.Parameters.AddWithValue("@Улица", textBox2.Text);
            command.Parameters.AddWithValue("@Дом", textBox3.Text);
            command.Parameters.AddWithValue("@Офис", textBox4.Text);
            command.Parameters.AddWithValue("@Этаж", textBox5.Text);
            command.Parameters.AddWithValue("@Площадь", textBox6.Text);
            command.Parameters.AddWithValue("@Тип_объявления", textBox7.Text);
            command.Parameters.AddWithValue("@Цена", textBox8.Text);

            DataRow nr1 = tb3.NewRow();
            nr1["Район"] = textBox1.Text;

            nr1["Улица"] = textBox2.Text;

            nr1["Дом"] = textBox3.Text;

            nr1["Офис"] = textBox4.Text;

            nr1["Этаж"] = textBox5.Text;

            nr1["Площадь"] = textBox6.Text;

            nr1["Тип_объявления"] = textBox7.Text;

            nr1["Цена"] = textBox8.Text;

            tb3.Rows.Add(nr1);


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
