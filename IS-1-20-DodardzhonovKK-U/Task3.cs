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


namespace IS_1_20_DodardzhonovKK_U
{
    public partial class Task3 : Form
    {

        //Переменная соединения
        MySqlConnection conn;
        //string connStr = "server=10.90.12.110;port=33333;user=st_1_20_13;database=is_1_20_st13_KURS;password=31485311;";
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_13;database=is_1_20_st13_KURS;password=31485311;";

        public Task3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand($"SELECT id_name, name_product, price_product, id_manuf, Manuf FROM PriceList INNER JOIN Manufacture ON id_name = id_manuf ;", conn);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int grid = dataGridView1.Rows.Add();
                    dataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                    dataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                    dataGridView1.Rows[grid].Cells[2].Value = reader[2].ToString();
                    dataGridView1.Rows[grid].Cells[3].Value = reader[3].ToString();
                    dataGridView1.Rows[grid].Cells[4].Value = reader[4].ToString();

                }

                reader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных");
            }
            finally
            {
                conn.Close();
            }
        }

        public void Task3_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string price = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string id_m = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string manuf = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            MessageBox.Show($" id: {id} \nНазвание: {name} \nЦена: {price} \nid_m: {id_m} \nПроизводители: {manuf}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu a = new Menu();
            a.ShowDialog();
        }
    }
}
