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

            //Загружаем таблицу houses
            SqlDataAdapter SDA2 = new SqlDataAdapter("LoadHouses", connection);
            SDA2.Fill(DS, "houses");
            tb2 = DS.Tables["houses"];
            dataGridView2.DataSource = DS.Tables["houses"];

            //Загружаем таблицу offices
            SqlDataAdapter SDA3 = new SqlDataAdapter("LoadOffices", connection);
            SDA3.Fill(DS, "offices");
            tb3 = DS.Tables["offices"];
            dataGridView3.DataSource = DS.Tables["offices"];

            //Загружаем таблицу garages
            SqlDataAdapter SDA4 = new SqlDataAdapter("LoadGarages", connection);
            SDA4.Fill(DS, "garages");
            tb4 = DS.Tables["garages"];
            dataGridView4.DataSource = DS.Tables["garages"];

            //Загружаем таблицу lots
            SqlDataAdapter SDA5 = new SqlDataAdapter("LoadLots", connection);
            SDA5.Fill(DS, "lots");
            tb5 = DS.Tables["lots"];
            dataGridView5.DataSource = DS.Tables["lots"];
        }


        public Form2(SqlConnection connection, string roleU)
        {
            InitializeComponent();
            comboBoxAdd.Items.Add("Квартиру");
            comboBoxAdd.Items.Add("Дом");
            comboBoxAdd.Items.Add("Офис");
            comboBoxAdd.Items.Add("Гараж");
            comboBoxAdd.Items.Add("Участок");
            comboBoxAdd.SelectedIndex = 0;
            this.connection = connection;
            LoadDB();
            // Определение какие элементы будут доступны для текущего пользователя
            if (roleU == "Клиент")
            {
                buttonAdd.Visible = false;
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
           
                
                
            }
            else if (roleU == "Риелтор")
            {
                buttonAdd.Visible = false;
                buttonDelete.Visible = false;
                
            }
            
        }

        private void Form2_Activated(object sender, EventArgs e)
        {

        }

        //Загрузка формы
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAdd.Text == "Дом")
            {
                (new Form5(DS.Tables["houses"],connection)).ShowDialog();
            }

            if (comboBoxAdd.Text == "Квартиру")
            {
                (new Form4(DS.Tables["flats"], connection)).ShowDialog();
            }
            if (comboBoxAdd.Text == "Офис")
            {
                (new Form6(DS.Tables["offices"], connection)).ShowDialog();
            }
            if (comboBoxAdd.Text == "Гараж")
            {
                (new Form7(DS.Tables["garages"], connection)).ShowDialog();
            }
            if (comboBoxAdd.Text == "Участок")
            {
                (new Form8(DS.Tables["lots"], connection)).ShowDialog();
            }
        }

    }
}
