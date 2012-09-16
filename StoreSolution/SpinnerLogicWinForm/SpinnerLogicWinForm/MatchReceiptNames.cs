using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicSpinner;

namespace SpinnerLogicWinForm
{
    public partial class MatchReceiptNames : Form
    {
        public MatchReceiptNames()
        {
            InitializeComponent();
        }

        private void MatchReceiptNames_Load(object sender, EventArgs e)
        {
            BpDS.ProductsDataTable dt = ProductBLL.Products();
            dt.CopyToDataTable(this.bpDS1.Products, LoadOption.OverwriteChanges);
        }
    }
}
