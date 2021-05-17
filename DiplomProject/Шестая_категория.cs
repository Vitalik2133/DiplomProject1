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
    public partial class Шестая_категория : Form
    {
        public Шестая_категория()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Molotilov403_ISiP_DiplomBaseDataSet);

        }

        private void Шестая_категория_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Molotilov403_ISiP_DiplomBaseDataSet.Категория_товаров". При необходимости она может быть перемещена или удалена.
            this.категория_товаровTableAdapter.Fill(this._Molotilov403_ISiP_DiplomBaseDataSet.Категория_товаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Molotilov403_ISiP_DiplomBaseDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this._Molotilov403_ISiP_DiplomBaseDataSet.Товары);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.товарыDataGridView.Sort(this.товарыDataGridView.Columns["Наименование"], ListSortDirection.Ascending);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.товарыDataGridView.Sort(this.товарыDataGridView.Columns["Наименование"], ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
