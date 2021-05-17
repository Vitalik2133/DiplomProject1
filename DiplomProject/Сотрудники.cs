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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Molotilov403_ISiP_DiplomBaseDataSet);

        }

        private void Сотрудники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Molotilov403_ISiP_DiplomBaseDataSet.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this._Molotilov403_ISiP_DiplomBaseDataSet.Пол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Molotilov403_ISiP_DiplomBaseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._Molotilov403_ISiP_DiplomBaseDataSet.Сотрудники);

            pictureBox1.Image = Image.FromFile(фотоTextBox.Text);

            if (полComboBox.Text == "1") { полComboBox.Text = "м"; }
           
              else
            {
                
                
                    полComboBox.Text = "ж";
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Аккаунт_сотрудника аккаунт_Сотрудника = new Аккаунт_сотрудника();
            аккаунт_Сотрудника.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.AddNew();
        }
    }
}
