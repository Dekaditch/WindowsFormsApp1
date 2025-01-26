namespace WindowsFormsApp1.Forms
{
    partial class SupplierForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLegalAddress = new System.Windows.Forms.TextBox();
            this.textSBank = new System.Windows.Forms.TextBox();
            this.textSBankNumber = new System.Windows.Forms.TextBox();
            this.textSITN = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSBank = new System.Windows.Forms.Label();
            this.labelSBankNumber = new System.Windows.Forms.Label();
            this.labelSITN = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(610, 47);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(144, 20);
            this.textName.TabIndex = 1;
            // 
            // textLegalAddress
            // 
            this.textLegalAddress.Location = new System.Drawing.Point(610, 109);
            this.textLegalAddress.Name = "textLegalAddress";
            this.textLegalAddress.Size = new System.Drawing.Size(144, 20);
            this.textLegalAddress.TabIndex = 2;
            // 
            // textSBank
            // 
            this.textSBank.Location = new System.Drawing.Point(610, 160);
            this.textSBank.Name = "textSBank";
            this.textSBank.Size = new System.Drawing.Size(144, 20);
            this.textSBank.TabIndex = 3;
            // 
            // textSBankNumber
            // 
            this.textSBankNumber.Location = new System.Drawing.Point(610, 218);
            this.textSBankNumber.Name = "textSBankNumber";
            this.textSBankNumber.Size = new System.Drawing.Size(144, 20);
            this.textSBankNumber.TabIndex = 4;
            // 
            // textSITN
            // 
            this.textSITN.Location = new System.Drawing.Point(610, 283);
            this.textSITN.Name = "textSITN";
            this.textSITN.Size = new System.Drawing.Size(144, 20);
            this.textSITN.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(510, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Имя поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Юридический адресс";
            // 
            // labelSBank
            // 
            this.labelSBank.AutoSize = true;
            this.labelSBank.Location = new System.Drawing.Point(507, 163);
            this.labelSBank.Name = "labelSBank";
            this.labelSBank.Size = new System.Drawing.Size(97, 13);
            this.labelSBank.TabIndex = 8;
            this.labelSBank.Text = "Банк поставщика";
            // 
            // labelSBankNumber
            // 
            this.labelSBankNumber.AutoSize = true;
            this.labelSBankNumber.Location = new System.Drawing.Point(458, 221);
            this.labelSBankNumber.Name = "labelSBankNumber";
            this.labelSBankNumber.Size = new System.Drawing.Size(146, 13);
            this.labelSBankNumber.TabIndex = 9;
            this.labelSBankNumber.Text = "Номер банкаовского счета";
            // 
            // labelSITN
            // 
            this.labelSITN.AutoSize = true;
            this.labelSITN.Location = new System.Drawing.Point(514, 286);
            this.labelSITN.Name = "labelSITN";
            this.labelSITN.Size = new System.Drawing.Size(90, 13);
            this.labelSITN.TabIndex = 10;
            this.labelSITN.Text = "ИНН поставщиа";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(445, 387);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 51);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(553, 387);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(104, 51);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Обновить информацию о поставщике";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(663, 387);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 51);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSITN);
            this.Controls.Add(this.labelSBankNumber);
            this.Controls.Add(this.labelSBank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textSITN);
            this.Controls.Add(this.textSBankNumber);
            this.Controls.Add(this.textSBank);
            this.Controls.Add(this.textLegalAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLegalAddress;
        private System.Windows.Forms.TextBox textSBank;
        private System.Windows.Forms.TextBox textSBankNumber;
        private System.Windows.Forms.TextBox textSITN;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSBank;
        private System.Windows.Forms.Label labelSBankNumber;
        private System.Windows.Forms.Label labelSITN;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}