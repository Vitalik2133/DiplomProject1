﻿using System;
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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void пользовательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользовательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Molotilov403_ISiP_DiplomBaseDataSet);

        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Molotilov403_ISiP_DiplomBaseDataSet.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.Fill(this._Molotilov403_ISiP_DiplomBaseDataSet.Пользователь);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация регистрация = new Регистрация();
            регистрация.Show();
        }
    }
}
