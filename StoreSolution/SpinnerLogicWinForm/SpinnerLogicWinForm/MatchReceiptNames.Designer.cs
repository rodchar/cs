namespace SpinnerLogicWinForm
{
    partial class MatchReceiptNames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbReceiptItemNames = new System.Windows.Forms.ListBox();
            this.lbProductNames = new System.Windows.Forms.ListBox();
            this.lvReceiptsProducts = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bpDS1 = new LogicSpinner.BpDS();
            ((System.ComponentModel.ISupportInitialize)(this.bpDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReceiptItemNames
            // 
            this.lbReceiptItemNames.FormattingEnabled = true;
            this.lbReceiptItemNames.Location = new System.Drawing.Point(167, 76);
            this.lbReceiptItemNames.Name = "lbReceiptItemNames";
            this.lbReceiptItemNames.Size = new System.Drawing.Size(120, 147);
            this.lbReceiptItemNames.TabIndex = 0;
            // 
            // lbProductNames
            // 
            this.lbProductNames.DataSource = this.bpDS1;
            this.lbProductNames.DisplayMember = "Products.Name";
            this.lbProductNames.FormattingEnabled = true;
            this.lbProductNames.Location = new System.Drawing.Point(309, 76);
            this.lbProductNames.Name = "lbProductNames";
            this.lbProductNames.Size = new System.Drawing.Size(120, 147);
            this.lbProductNames.TabIndex = 1;
            this.lbProductNames.ValueMember = "Products.Id";
            // 
            // lvReceiptsProducts
            // 
            this.lvReceiptsProducts.Location = new System.Drawing.Point(167, 250);
            this.lvReceiptsProducts.Name = "lvReceiptsProducts";
            this.lvReceiptsProducts.Size = new System.Drawing.Size(262, 142);
            this.lvReceiptsProducts.TabIndex = 2;
            this.lvReceiptsProducts.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(70, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(459, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 416);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(343, 416);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // bpDS1
            // 
            this.bpDS1.DataSetName = "BpDS";
            this.bpDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MatchReceiptNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 506);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvReceiptsProducts);
            this.Controls.Add(this.lbProductNames);
            this.Controls.Add(this.lbReceiptItemNames);
            this.Name = "MatchReceiptNames";
            this.Text = "MatchReceiptNames";
            this.Load += new System.EventHandler(this.MatchReceiptNames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bpDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReceiptItemNames;
        private System.Windows.Forms.ListBox lbProductNames;
        private System.Windows.Forms.ListView lvReceiptsProducts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private LogicSpinner.BpDS bpDS1;
    }
}