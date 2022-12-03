using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_DodardzhonovKK_U
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Task1 f = new Task1();
            //Вызов формы в режиме диалога
            f.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Task2 f = new Task2();
            //Вызов формы в режиме диалога
            f.ShowDialog();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Task3 f = new Task3();
            //Вызов формы в режиме диалога
            f.ShowDialog();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Task4 f = new Task4();
            //Вызов формы в режиме диалога
            f.ShowDialog();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Task5 f = new Task5();
            //Вызов формы в режиме диалога
            f.ShowDialog();

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
