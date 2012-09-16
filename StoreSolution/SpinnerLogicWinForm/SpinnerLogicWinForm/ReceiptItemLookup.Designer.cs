namespace SpinnerLogicWinForm
{
    partial class ReceiptItemLookup
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbReceiptsProducts = new System.Windows.Forms.TextBox();
            this.btnAddReceiptItemName = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbReceiptsProducts = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt Name, Product Name";
            // 
            // tbReceiptsProducts
            // 
            this.tbReceiptsProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceiptsProducts.Location = new System.Drawing.Point(146, 61);
            this.tbReceiptsProducts.Name = "tbReceiptsProducts";
            this.tbReceiptsProducts.Size = new System.Drawing.Size(258, 29);
            this.tbReceiptsProducts.TabIndex = 1;
            this.tbReceiptsProducts.Click += new System.EventHandler(this.tbReceiptsProducts_Click);
            // 
            // btnAddReceiptItemName
            // 
            this.btnAddReceiptItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReceiptItemName.Location = new System.Drawing.Point(43, 61);
            this.btnAddReceiptItemName.Name = "btnAddReceiptItemName";
            this.btnAddReceiptItemName.Size = new System.Drawing.Size(97, 32);
            this.btnAddReceiptItemName.TabIndex = 3;
            this.btnAddReceiptItemName.TabStop = false;
            this.btnAddReceiptItemName.Text = "Add";
            this.btnAddReceiptItemName.UseVisualStyleBackColor = true;
            this.btnAddReceiptItemName.Click += new System.EventHandler(this.btnAddReceiptItemName_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(146, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(316, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbReceiptsProducts
            // 
            this.lbReceiptsProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceiptsProducts.FormattingEnabled = true;
            this.lbReceiptsProducts.ItemHeight = 24;
            this.lbReceiptsProducts.Location = new System.Drawing.Point(146, 96);
            this.lbReceiptsProducts.Name = "lbReceiptsProducts";
            this.lbReceiptsProducts.Size = new System.Drawing.Size(258, 172);
            this.lbReceiptsProducts.TabIndex = 6;
            this.lbReceiptsProducts.Click += new System.EventHandler(this.lbReceiptsProducts_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(43, 139);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 32);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(410, 61);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 32);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ReceiptItemLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 343);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbReceiptsProducts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddReceiptItemName);
            this.Controls.Add(this.tbReceiptsProducts);
            this.Controls.Add(this.label1);
            this.Name = "ReceiptItemLookup";
            this.Text = "ReceiptItemLookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReceiptsProducts;
        private System.Windows.Forms.Button btnAddReceiptItemName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbReceiptsProducts;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFind;
    }
}