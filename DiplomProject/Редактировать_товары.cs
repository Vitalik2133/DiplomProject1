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
    public partial class Редактировать_товары : Form
    {
        public Редактировать_товары()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Molotilov403_ISiP_DiplomBaseDataSet);

        }

        private void Редактировать_товары_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Molotilov403_ISiP_DiplomBaseDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this._Molotilov403_ISiP_DiplomBaseDataSet.Товары);
            pictureBox2.Image = Image.FromFile(фото_товараTextBox.Text);
            pictureBox1.Image = Image.FromFile(лого_товараTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Molotilov403_ISiP_DiplomBaseDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.товарыBindingSource.AddNew();
        }
    }
}
