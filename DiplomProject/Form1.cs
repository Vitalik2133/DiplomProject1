using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Сотрудники сотрудники = new Сотрудники();
            сотрудники.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Первая_категория первая_Категория = new Первая_категория();
            первая_Категория.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Вторая_категория вторая_Категория = new Вторая_категория();
            вторая_Категория.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Третья_категория третья = new Третья_категория();
            третья.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Четвертая_категория четвертая_Категория = new Четвертая_категория();
            четвертая_Категория.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Пятая_категория пятая_Категория = new Пятая_категория();
            пятая_Категория.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Шестая_категория шестая_Категория = new Шестая_категория();
            шестая_Категория.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Сообщить_об_ошибке сообщить_Об_Ошибке = new Сообщить_об_ошибке();
            сообщить_Об_Ошибке.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Авторизация авторизация = new Авторизация();
            авторизация.Show();
        }
    }
}
