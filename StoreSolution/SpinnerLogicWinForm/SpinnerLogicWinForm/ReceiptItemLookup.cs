using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpinnerLogicWinForm
{
    public partial class ReceiptItemLookup : Form
    {
        public ReceiptItemLookup()
        {
            InitializeComponent();
        }

        private void btnAddReceiptItemName_Click(object sender, EventArgs e)
        {

            lbReceiptsProducts.Items.Add(tbReceiptsProducts.Text);
            tbReceiptsProducts.Clear();
            tbReceiptsProducts.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbReceiptsProducts.Items.Remove(lbReceiptsProducts.SelectedItem);
        }

        private void lbReceiptsProducts_Click(object sender, EventArgs e)
        {
            if (lbReceiptsProducts.SelectedIndex > -1)
            {
                tbReceiptsProducts.Text = lbReceiptsProducts.SelectedValue.ToString();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int sel = lbReceiptsProducts.FindString(tbReceiptsProducts.Text);
            lbReceiptsProducts.SelectedIndex = sel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var items = lbReceiptsProducts.Items;

            var toBusiness = new List<string>();

            foreach (var item in items)
            {
                toBusiness.Add(item.ToString());    
            }
        }
    }
}
