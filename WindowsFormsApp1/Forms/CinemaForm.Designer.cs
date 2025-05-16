namespace WindowsFormsApp1.Forms
{
    partial class CinemaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textDirector = new System.Windows.Forms.TextBox();
            this.textOwner = new System.Windows.Forms.TextBox();
            this.textBank = new System.Windows.Forms.TextBox();
            this.textBankNumber = new System.Windows.Forms.TextBox();
            this.textITN = new System.Windows.Forms.TextBox();
            this.textSeats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адресс кинотеатра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Контактный телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Директор";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(600, 36);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(144, 20);
            this.textAddress.TabIndex = 4;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(600, 77);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(144, 20);
            this.textPhone.TabIndex = 5;
            // 
            // textDirector
            // 
            this.textDirector.Location = new System.Drawing.Point(600, 125);
            this.textDirector.Name = "textDirector";
            this.textDirector.Size = new System.Drawing.Size(144, 20);
            this.textDirector.TabIndex = 6;
            // 
            // textOwner
            // 
            this.textOwner.Location = new System.Drawing.Point(600, 178);
            this.textOwner.Name = "textOwner";
            this.textOwner.Size = new System.Drawing.Size(144, 20);
            this.textOwner.TabIndex = 7;
            // 
            // textBank
            // 
            this.textBank.Location = new System.Drawing.Point(600, 224);
            this.textBank.Name = "textBank";
            this.textBank.Size = new System.Drawing.Size(144, 20);
            this.textBank.TabIndex = 8;
            // 
            // textBankNumber
            // 
            this.textBankNumber.Location = new System.Drawing.Point(600, 273);
            this.textBankNumber.Name = "textBankNumber";
            this.textBankNumber.Size = new System.Drawing.Size(144, 20);
            this.textBankNumber.TabIndex = 9;
            // 
            // textITN
            // 
            this.textITN.Location = new System.Drawing.Point(600, 320);
            this.textITN.Name = "textITN";
            this.textITN.Size = new System.Drawing.Size(144, 20);
            this.textITN.TabIndex = 10;
            // 
            // textSeats
            // 
            this.textSeats.Location = new System.Drawing.Point(600, 366);
            this.textSeats.Name = "textSeats";
            this.textSeats.Size = new System.Drawing.Size(144, 20);
            this.textSeats.TabIndex = 11;
            this.textSeats.TextChanged += new System.EventHandler(this.textSeats_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Владелец кинотеатра";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Банк";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер банка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ИНН кинотеатра";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Кол-во сидений";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(451, 436);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(102, 51);
            this.button_Add.TabIndex = 17;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(559, 436);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(102, 51);
            this.button_Update.TabIndex = 18;
            this.button_Update.Text = "Обновить информацию о кинотеатре";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(667, 436);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(102, 51);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // CinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSeats);
            this.Controls.Add(this.textITN);
            this.Controls.Add(this.textBankNumber);
            this.Controls.Add(this.textBank);
            this.Controls.Add(this.textOwner);
            this.Controls.Add(this.textDirector);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CinemaForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textDirector;
        private System.Windows.Forms.TextBox textOwner;
        private System.Windows.Forms.TextBox textBank;
        private System.Windows.Forms.TextBox textBankNumber;
        private System.Windows.Forms.TextBox textITN;
        private System.Windows.Forms.TextBox textSeats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
    }
}