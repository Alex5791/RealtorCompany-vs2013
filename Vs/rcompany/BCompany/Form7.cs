﻿using System;
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
    public partial class Form7 : Form
    {
        public DataTable tb4;
        public SqlConnection connection;
        public SqlCommand command;
        public Form7(DataTable tb4, SqlConnection connection)
        {
            InitializeComponent();
            this.tb4 = tb4;
            this.connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("AddGarage", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Район", textBox1.Text);
            command.Parameters.AddWithValue("@Улица", textBox2.Text);
            command.Parameters.AddWithValue("@Площадь", textBox3.Text);
            command.Parameters.AddWithValue("@Тип_объявления", textBox4.Text);
            command.Parameters.AddWithValue("@Цена", textBox5.Text);

            DataRow nr1 = tb4.NewRow();
            nr1["Район"] = textBox1.Text;

            nr1["Улица"] = textBox2.Text;

            nr1["Площадь"] = textBox3.Text;

            nr1["Тип_объявления"] = textBox4.Text;

            nr1["Цена"] = textBox5.Text;


            tb4.Rows.Add(nr1);


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