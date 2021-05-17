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
    public partial class Сообщить_об_ошибке : Form
    {
        public Сообщить_об_ошибке()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (StreamWriter incdate = File.AppendText(@"D:\incdate.txt"))
            //{
            //    incdate.WriteLine(textBox1.Text, '\n');
            //}
            //this.Close();
        }
    }
}
