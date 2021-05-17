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
    public partial class Аккаунт_сотрудника : Form
    {
        public Аккаунт_сотрудника()
        {
            InitializeComponent();
        }

        private void аккаунт_сотрудникаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.аккаунт_сотрудникаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Molotilov403_ISiP_DiplomBaseDataSet);

        }

        private void Аккаунт_сотрудника_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Molotilov403_ISiP_DiplomBaseDataSet.Аккаунт_сотрудника". При необходимости она может быть перемещена или удалена.
            this.аккаунт_сотрудникаTableAdapter.Fill(this._Molotilov403_ISiP_DiplomBaseDataSet.Аккаунт_сотрудника);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.аккаунт_сотрудникаBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
