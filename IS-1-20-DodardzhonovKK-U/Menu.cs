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

        class Accessories<P>
        {
            public int price;
            public int release_year;
            public P articul;

        

        public Accessories (int price, int release_year, P articul)
            {
            this.price = price;
            this.release_year = release_year;
            this.articul = articul;
            }


            public void Display()
            {
                MessageBox.Show($"Цена: {price}  \nГод выпуска: {release_year} \nАртикул {articul} ");
            }

            class Hard_drives<P> : Accessories<P>
            {
                public int NR { get; set; }
                public string Interface { get; set; }
                public int Volume { get; set; }

                public Hard_drives (int NR, string Interface, int Volume, int price, int release_year, P articul) : base (price, release_year, articul)
                {
                    this.NR = NR;
                    this.Interface = Interface;
                    this.Volume = Volume;
                }

                public new void Display()
                {
                    MessageBox.Show($"Артикул {articul} \nЦена: {price}  \nГод выпуска: {release_year} \nКоличество Оборотов: {NR} Интерфейс: {Interface} Объем: {Volume} ");
                }
            }

            class Videocard<P> : Accessories<P>
            {
                public int GPUfreq;
                public string manuf;
                public int memory;

                public Videocard (int NR, string Interface, int Volume, int price, int release_year, P articul) : base(price, release_year, articul)
                {
                    this.NR = NR;
                    this.Interface = Interface;
                    this.Volume = Volume;
                }

            }


        }






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
    }
}
