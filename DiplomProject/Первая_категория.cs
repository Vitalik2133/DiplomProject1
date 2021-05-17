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
    public partial class Первая_категория : Form
    {
        public Первая_категория()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Molotilov403_ISiP_DiplomBaseDataSet);

        }

        private void Первая_категория_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Molotilov403_ISiP_DiplomBaseDataSet.Характеристики_товаров". При необходимости она может быть перемещена или удалена.
            this.характеристики_товаровTableAdapter.Fill(this._Molotilov403_ISiP_DiplomBaseDataSet.Характеристики_товаров);
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

        private void FirstCategory_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Редактировать_товары редактировать_Товары = new Редактировать_товары();
            редактировать_Товары.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           // this.товарыDataGridView.Sort(this.товарыDataGridView.Columns["Оценка"], ListSortDirection.Ascending);
        }

        private void label5_Click(object sender, EventArgs e)
        {
           // this.товарыDataGridView.Sort(this.товарыDataGridView.Columns["Оценка"], ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
