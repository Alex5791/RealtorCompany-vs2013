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
    public partial class Form2 : Form
    {
        public string roleU;
        SqlCommand cmd = new SqlCommand();
        public SqlConnection connection;
        DataSet DS = new DataSet();
        DataTable tb1 = new DataTable();
        DataTable tb2 = new DataTable();
        DataTable tb3 = new DataTable();
        DataTable tb4 = new DataTable();
        DataTable tb5 = new DataTable();
            void LoadDB()
        {
            //Загружаем таблицу flats
            SqlDataAdapter SDA1 = new SqlDataAdapter("LoadFlats", connection);
            SDA1.Fill(DS, "flats");
            tb1 = DS.Tables["flats"];
            dataGridView1.DataSource = DS.Tables["flats"];


        /*//Размещение таблицы по всему размеру datagridview
        dataGridView1.AllowUserToResizeColumns = true;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
       
        */ 
        // Ширина столбцов по длине значения столбца
        dataGridView1.AutoResizeColumns();
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        

            //Загружаем таблицу houses
            SqlDataAdapter SDA2 = new SqlDataAdapter("LoadHouses", connection);
            SDA2.Fill(DS, "houses");
            tb2 = DS.Tables["houses"];
            dataGridView2.DataSource = DS.Tables["houses"];

            // Ширина столбцов по длине значения столбца
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Загружаем таблицу offices
            SqlDataAdapter SDA3 = new SqlDataAdapter("LoadOffices", connection);
            SDA3.Fill(DS, "offices");
            tb3 = DS.Tables["offices"];
            dataGridView3.DataSource = DS.Tables["offices"];

            // Ширина столбцов по длине значения столбца
            dataGridView3.AutoResizeColumns();
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Загружаем таблицу garages
            SqlDataAdapter SDA4 = new SqlDataAdapter("LoadGarages", connection);
            SDA4.Fill(DS, "garages");
            tb4 = DS.Tables["garages"];
            dataGridView4.DataSource = DS.Tables["garages"];

            // Ширина столбцов по длине значения столбца
            dataGridView4.AutoResizeColumns();
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Загружаем таблицу lots
            SqlDataAdapter SDA5 = new SqlDataAdapter("LoadLots", connection);
            SDA5.Fill(DS, "lots");
            tb5 = DS.Tables["lots"];
            dataGridView5.DataSource = DS.Tables["lots"];

            // Ширина столбцов по длине значения столбца
            dataGridView5.AutoResizeColumns();
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }



        public Form2(SqlConnection connection, string roleU)
        {
            InitializeComponent();
            comboBoxAdd.Items.Add("Квартиру");
            comboBoxAdd.Items.Add("Дом");
            comboBoxAdd.Items.Add("Офис");
            comboBoxAdd.Items.Add("Гараж");
            comboBoxAdd.Items.Add("Участок");

            comboBoxEdit.Items.Add("Квартиру");
            comboBoxEdit.Items.Add("Дом");
            comboBoxEdit.Items.Add("Офис");
            comboBoxEdit.Items.Add("Гараж");
            comboBoxEdit.Items.Add("Участок");

            comboBoxDelete.Items.Add("Квартиру");
            comboBoxDelete.Items.Add("Дом");
            comboBoxDelete.Items.Add("Офис");
            comboBoxDelete.Items.Add("Гараж");
            comboBoxDelete.Items.Add("Участок");


            this.connection = connection;
            LoadDB();


            // Определение какие элементы будут доступны для текущего пользователя
            if (roleU == "Клиент")
            {
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
                comboBoxDelete.Visible = false;
                comboBoxEdit.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                    
            }
            else if (roleU == "Риелтор")
            {
                buttonDelete.Visible = false;
                comboBoxDelete.Visible = false;
                textBox2.Visible = false;
                
            }
            
        }

        private void Form2_Activated(object sender, EventArgs e)
        {

        }

        //Загрузка формы
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        //кнопка buttonAdd - конструктор формы, вызывающая форму добавления объявления в зависимости
        // от выбранного типа объявления в comboBoxEdit. Передаем таблицу, подключение и номер изменяемого объявления (string)
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAdd.Text == "Дом")
            {
                (new Form5(DS.Tables["houses"],connection, textBox1.Text)).ShowDialog();
            }

            if (comboBoxAdd.Text == "Квартиру")
            {
                (new Form4(DS.Tables["flats"], connection, textBox1.Text)).ShowDialog();
            }
            if (comboBoxAdd.Text == "Офис")
            {
                (new Form6(DS.Tables["offices"], connection, textBox1.Text)).ShowDialog();
            }
            if (comboBoxAdd.Text == "Гараж")
            {
                (new Form7(DS.Tables["garages"], connection, textBox1.Text)).ShowDialog();
            }
            if (comboBoxAdd.Text == "Участок")
            {
                (new Form8(DS.Tables["lots"], connection, textBox1.Text)).ShowDialog();
            }
        }
        
        // кнопка buttonEdit - конструктор формы, вызывающая форму изменения объявления в зависимости
        // от выбранного типа объявления в comboBoxEdit. Передаем таблицу, подключение и номер изменяемого объявления (string)
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit.Text == "Дом")
            {
                (new Form5(DS.Tables["houses"], connection, textBox1.Text)).ShowDialog();
            }

            if (comboBoxEdit.Text == "Квартиру")
            {
                (new Form4(DS.Tables["flats"], connection, textBox1.Text)).ShowDialog();
            }
            if (comboBoxEdit.Text == "Офис")
            {
                (new Form6(DS.Tables["offices"], connection, textBox1.Text)).ShowDialog();
            }
            if (comboBoxEdit.Text == "Гараж")
            {
                (new Form7(DS.Tables["garages"], connection, textBox1.Text)).ShowDialog();
            }
            if (comboBoxEdit.Text == "Участок")
            {
                (new Form8(DS.Tables["lots"], connection, textBox1.Text)).ShowDialog();
            }
        }

        // buttonDelete - удаление из таблицы, выбранной в comboBoxDelete, по номеру объявления из textBox2(Id объявления)
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxDelete.Text == "Квартиру")
            {
                SqlCommand command = new SqlCommand("DeleteFlat", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@N", textBox2.Text);
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
            if (comboBoxDelete.Text == "Офис")
            {
                SqlCommand command = new SqlCommand("DeleteOffice", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@N", textBox2.Text);
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
            if (comboBoxDelete.Text == "Дом")
            {
                SqlCommand command = new SqlCommand("DeleteHouse", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@N", textBox2.Text);
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
            if (comboBoxDelete.Text == "Гараж")
            {
                SqlCommand command = new SqlCommand("DeleteGarage", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@N", textBox2.Text);
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
            if (comboBoxDelete.Text == "Участок")
            {
                SqlCommand command = new SqlCommand("DeleteLot", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@N", textBox2.Text);
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
