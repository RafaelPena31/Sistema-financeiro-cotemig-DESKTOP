﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_finaneiro
{
    public partial class Update_Recipe : Form
    {
        public Update_Recipe()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;

        public void limparRecipe()
        {
            cbxUpdateNameRecipe.SelectedIndex = -1;
            dtpUpdateDateRecipe.Value = ''; 

        }

        private void Update_Recipe_Load(object sender, EventArgs e)
        {

        }

        private void dtpDateRecipe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtValueRecipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxNameRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
