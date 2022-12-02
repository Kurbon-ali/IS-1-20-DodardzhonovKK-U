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
    public partial class Task1 : Form
    {


        class Accessories<P>
        {
            public int price;
            public int release_year;
            public P articul;



            public Accessories(int price, int release_year, P articul)
            {
                this.price = price;
                this.release_year = release_year;
                this.articul = articul;
            }


            public void Display()
            {
                MessageBox.Show($"Артикул {articul}  \nГод выпуска: {release_year} \nЦена: {price} ");
            }

        }

            class Harddrives<P> : Accessories<P>
            {
                public int NR { get; set; }
                public string Interface { get; set; }
                public int Volume { get; set; }

                public Harddrives(P articul, int price, int release_year, int NR, string Interface, int Volume) : base(price, release_year, articul)
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

                public Videocard(P articul, int price, int release_year,  int GPUfreq, string manuf, int memory) : base(price, release_year, articul)
                {
                    this.GPUfreq = GPUfreq;
                    this.manuf = manuf;
                    this.memory = memory;
                }

                public new void Display()
                {

                    MessageBox.Show($"Артикул {articul} \nЦена: {price}  \nГод выпуска: {release_year} \nЧастота: {GPUfreq} Производитель: {manuf} Объем Памяти: {memory} ");
                }
            }
        



            public Task1()
            {
                InitializeComponent();
            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void Task1_Load(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Артикул: {textBox1.Text}");
                listBox1.Items.Add($"Цена: {textBox2.Text}");
                listBox1.Items.Add($"Год выпуска: {textBox3.Text}");
                listBox1.Items.Add($"Количество Оборотов: {textBox4.Text}");
                listBox1.Items.Add($"Интерфейс: {textBox5.Text}");
                listBox1.Items.Add($"Объем: {textBox6.Text}");
                Harddrives<int> a1 = new Harddrives<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text));
                a1.Display();
            }



            private void button2_Click(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Артикул: {textBox1.Text}");
                listBox1.Items.Add($"Цена: {textBox2.Text}");
                listBox1.Items.Add($"Год выпуска: {textBox3.Text}");
                listBox1.Items.Add($"Частота: {textBox7.Text}");
                listBox1.Items.Add($"Производитель: {textBox8.Text}");
                listBox1.Items.Add($"Объем Памяти: {textBox9.Text}");
                Videocard<int> a1 = new Videocard<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text));
                a1.Display();

            }


    }
}
