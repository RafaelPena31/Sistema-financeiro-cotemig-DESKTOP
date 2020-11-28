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

        private void Update_Recipe_Load(object sender, EventArgs e)
        {

        }

        private void dtpUpdateDateRecipe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateValueRecipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxUpdateNameRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUptadeRecipeReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUpdateRecipeId_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtUpdateRecipeId.Text != "")
            {
                sql = string.Format("select Category.name, Registration.data, Registration.value from Registration join Category on Category_id = Category.id where Registration.User_id = '{0}' and Registration.id = '{1}'",
                    UserClass.getUserId(), int.Parse(txtUpdateRecipeId.Text));
                dt = UserClass.DataList(sql);

                if (dt.Rows.Count > 0)
                {
                    cbxUpdateNameRecipe.Text = dt.Rows[0]["name"].ToString();
                    dtpUpdateDateRecipe.Text = dt.Rows[0]["data"].ToString();
                    txtUpdateValueRecipe.Text = dt.Rows[0]["value"].ToString();
                }
            }
        }

        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            sql = string.Format("update Registration set Category_id = '{0}', value = '{1}', data = '{2}' where id ='{3}'", Convert.ToInt32(cbxUpdateNameRecipe.SelectedValue.ToString()),
            Double.Parse(txtUpdateValueRecipe.Text), dtpUpdateDateRecipe.Value.ToString("yyyy-MM-dd"), int.Parse(txtUpdateRecipeId.Text));
            UserClass.UpdateData(sql);
            MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que gostaria de excluir este dado de sua conta? A ação será irreversível!", "Deletar", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                sql = string.Format("delete from Registration where id = '{0}'", int.Parse(txtUpdateRecipeId.Text));
                if (UserClass.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso", "Deletado", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seus dados não poderam ser excluidos com sucesso. Entre em contato com o suporte.", "Deletado", MessageBoxButtons.OK);
                }
            }
        }
    }
}
