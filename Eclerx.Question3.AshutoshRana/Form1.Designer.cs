namespace Eclerx.Question3.AshutoshRana
{
    partial class Form1
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
            this.LblAccountNo = new System.Windows.Forms.Label();
            this.LblTransactionType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.LblBalanceAmount = new System.Windows.Forms.Label();
            this.TxtAccountNo = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.ComboTransactionType = new System.Windows.Forms.ComboBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblShowBalanceAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAccountNo
            // 
            this.LblAccountNo.AutoSize = true;
            this.LblAccountNo.Location = new System.Drawing.Point(139, 44);
            this.LblAccountNo.Name = "LblAccountNo";
            this.LblAccountNo.Size = new System.Drawing.Size(64, 13);
            this.LblAccountNo.TabIndex = 0;
            this.LblAccountNo.Text = "Account No";
            // 
            // LblTransactionType
            // 
            this.LblTransactionType.AutoSize = true;
            this.LblTransactionType.Location = new System.Drawing.Point(139, 80);
            this.LblTransactionType.Name = "LblTransactionType";
            this.LblTransactionType.Size = new System.Drawing.Size(90, 13);
            this.LblTransactionType.TabIndex = 1;
            this.LblTransactionType.Text = "Transaction Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(139, 121);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // LblBalanceAmount
            // 
            this.LblBalanceAmount.AutoSize = true;
            this.LblBalanceAmount.Location = new System.Drawing.Point(139, 246);
            this.LblBalanceAmount.Name = "LblBalanceAmount";
            this.LblBalanceAmount.Size = new System.Drawing.Size(85, 13);
            this.LblBalanceAmount.TabIndex = 3;
            this.LblBalanceAmount.Text = "Balance Amount";
            // 
            // TxtAccountNo
            // 
            this.TxtAccountNo.Location = new System.Drawing.Point(239, 41);
            this.TxtAccountNo.Name = "TxtAccountNo";
            this.TxtAccountNo.Size = new System.Drawing.Size(121, 20);
            this.TxtAccountNo.TabIndex = 4;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(239, 121);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(121, 20);
            this.TxtAmount.TabIndex = 5;
            // 
            // ComboTransactionType
            // 
            this.ComboTransactionType.FormattingEnabled = true;
            this.ComboTransactionType.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.ComboTransactionType.Location = new System.Drawing.Point(239, 77);
            this.ComboTransactionType.Name = "ComboTransactionType";
            this.ComboTransactionType.Size = new System.Drawing.Size(121, 21);
            this.ComboTransactionType.TabIndex = 6;
            this.ComboTransactionType.Text = "--Please Select--";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(176, 175);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(269, 175);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblShowBalanceAmount
            // 
            this.LblShowBalanceAmount.AutoSize = true;
            this.LblShowBalanceAmount.Location = new System.Drawing.Point(266, 246);
            this.LblShowBalanceAmount.Name = "LblShowBalanceAmount";
            this.LblShowBalanceAmount.Size = new System.Drawing.Size(0, 13);
            this.LblShowBalanceAmount.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 311);
            this.Controls.Add(this.LblShowBalanceAmount);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.ComboTransactionType);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TxtAccountNo);
            this.Controls.Add(this.LblBalanceAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.LblTransactionType);
            this.Controls.Add(this.LblAccountNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAccountNo;
        private System.Windows.Forms.Label LblTransactionType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label LblBalanceAmount;
        private System.Windows.Forms.TextBox TxtAccountNo;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.ComboBox ComboTransactionType;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblShowBalanceAmount;
    }
}

