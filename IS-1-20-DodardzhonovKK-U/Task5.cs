using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static ConnectDB.ConnectDB;

namespace IS_1_20_DodardzhonovKK_U
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        public MySqlConnection conn;
        //string connStr = "server=10.90.12.110;port=33333;user=st_1_20_13;database=is_1_20_st13_KURS;password=31485311;";
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_13;database=is_1_20_st13_KURS;password=31485311;";

        public void Task5_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);

        }

        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string fioStud = textBox1.Text;
                string datetimeStud = textBox2.Text;
                conn.Open();
                string sql = $"INSERT INTO t_Uchebka_DodardzhonovKK(fioStud, datetimeStud) " +
                    $"VALUES ('{fioStud}', '{String.Format("{0:s}", datetimeStud)}');" +
                    $"SELECT idStud FROM t_Uchebka_DodardzhonovKK WHERE(idStud = LAST_INSERT_ID());";
                MySqlCommand command = new MySqlCommand(sql, conn);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void button2_Click(object sender, EventArgs e)

        {
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM t_Uchebka_DodardzhonovKK;", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int grid = dataGridView1.Rows.Add();
                dataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                dataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                dataGridView1.Rows[grid].Cells[2].Value = DateTime.Parse(reader[2].ToString());
            }

            reader.Close();
        }
    }
}


        
    

