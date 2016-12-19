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
    public partial class Form1 : Form
    {
        public readonly string DB_NAME = "pronin_db";
        public readonly string DB_USER = "pronin484";
        public readonly string DB_PASS = "123";
        public const int NON_EXISTEN_USER_ID = -1;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Клиент");
            comboBox1.Items.Add("Риелтор");
            comboBox1.Items.Add("Менеджер");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=";

            string serverName;
            switch (tbServer.Text)
            {
                case "":
                case null:
                    serverName = "null";
                    break;

                default:
                    serverName = tbServer.Text;
                    break;
            }
            connection.ConnectionString += serverName;
            connection.ConnectionString += String.Format(";Initial Catalog = {0};User ID = {1};Password = {2}", this.DB_NAME, this.DB_USER, this.DB_PASS);
            try
            {
                SqlCommand command = new SqlCommand("UserIDCheck", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Login", SqlDbType.NVarChar, 20);
                command.Parameters["@Login"].Value = tbLogin.Text;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 20);
                command.Parameters["@password"].Value = tbPass.Text;
                command.Parameters.Add("@Role", SqlDbType.NVarChar, 20);
                command.Parameters["@Role"].Value = comboBox1.Text;
                command.Parameters.Add("@UserID", SqlDbType.Int).Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                int userID = Convert.ToInt32(command.Parameters["@UserID"].Value);

                if (userID == NON_EXISTEN_USER_ID)
                {
                    throw new Exception("Такого пользователя не существует!");
                }
                else
                {
                    Hide();
                    (new Form2(connection, comboBox1.Text)).ShowDialog();
                    Close();
                }
            }
            catch (SqlException SqlEx)
            {
                foreach (SqlError er in SqlEx.Errors)
                {
                    string erType = er.Class >= 11 && er.Class <= 16 ? "Ошибка пользователя" : (er.Class >= 17 && er.Class <= 25 ? "Ошибка программного обеспечения или оборудования" : "Unknown Error");
                    MessageBox.Show(er.Message, erType, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
