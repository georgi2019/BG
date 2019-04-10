using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DoubleBuffered = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Вперед")
            {
                pictureBox2.Image = Properties.Resources.solding2;
                pictureBox1.Image = null;
            }
            if (comboBox2.Text == "Вперед")
            {
                pictureBox3.Image = Properties.Resources.solding2;
                pictureBox2.Image = null;
                label2.Text = "1";
            }
            if (comboBox3.Text == "Вперед")
            {
                pictureBox4.Image = Properties.Resources.solding2;
                pictureBox3.Image = null;
            }
            if (comboBox4.Text == "Поворот налево")
            {
                pictureBox4.Image = Properties.Resources.solding;
                pictureBox3.Image = null;
            }
            if (comboBox5.Text == "Вперед")
            {
                pictureBox5.Image = Properties.Resources.solding;
                pictureBox4.Image = null;
            }
            if (comboBox6.Text == "Вперед")
            {
                pictureBox6.Image = Properties.Resources.solding;
                pictureBox5.Image = null;
                label2.Text = "2";
            }
            if (comboBox7.Text == "Вперед")
            {
                pictureBox7.Image = Properties.Resources.solding;
                pictureBox6.Image = null;
                label2.Text = "3";
            }
            if (comboBox8.Text == "Вперед")
            {
                pictureBox8.Image = Properties.Resources.solding;
                pictureBox7.Image = null;
            }
           if (comboBox9.Text == "Вперед" && comboBox1.Text == "Вперед" && comboBox2.Text == "Вперед" && comboBox3.Text == "Вперед" && comboBox4.Text == "Поворот налево" && comboBox5.Text == "Вперед" && comboBox6.Text == "Вперед" && comboBox7.Text == "Вперед" && comboBox8.Text == "Вперед")
           {
                pictureBox9.Image = Properties.Resources.solding;
                pictureBox8.Image = null;
                MessageBox.Show("Уровень пройден! Собрано 3 материала");     
           }
           
            else 
            {
                MessageBox.Show("Неправильно! Вы сломали программу ^_^. Попробуйте занова, для этого нажмите на кнопку сброс");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вам нужно довезти шахтера до сундука с золотом, используя команды, которые даны слева. Для прохождения уровня все команды должны быть заданы, иначе программа вам выдаст ошибку!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            pictureBox1.Image = Properties.Resources.solding2;
            pictureBox2.Image = Properties.Resources.block;
            pictureBox3.Image = Properties.Resources.ugol;
            pictureBox4.Image = Properties.Resources.block;
            pictureBox5.Image = Properties.Resources.block;
            pictureBox6.Image = Properties.Resources.block;
            pictureBox7.Image = Properties.Resources.ugol;
            pictureBox8.Image = Properties.Resources.ugol;
            pictureBox9.Image = Properties.Resources.sunduk;
            label2.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
