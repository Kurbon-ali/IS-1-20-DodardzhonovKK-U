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

        //DataAdapter представляет собой объект Command , получающий данные из источника данных
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        //Объявление BindingSource, основная его задача, это обеспечить унифицированный доступ к источнику данных
        private BindingSource bSource = new BindingSource();
        
        private DataSet ds = new DataSet();
        //Представляет одну таблицу данных в памяти
        private DataTable table = new DataTable();

        

        public Task3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Task3_Load(object sender, EventArgs e)
        {

        }
    }
}
