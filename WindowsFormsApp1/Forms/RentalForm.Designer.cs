namespace WindowsFormsApp1.Forms
{
    partial class RentalForm
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
            System.Windows.Forms.Label label5;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pickFilm = new System.Windows.Forms.ComboBox();
            this.pickCinema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.textPenalty = new System.Windows.Forms.TextBox();
            this.textRentCost = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(535, 192);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(33, 13);
            label5.TabIndex = 7;
            label5.Text = "Пени";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // pickFilm
            // 
            this.pickFilm.FormattingEnabled = true;
            this.pickFilm.Location = new System.Drawing.Point(574, 37);
            this.pickFilm.Name = "pickFilm";
            this.pickFilm.Size = new System.Drawing.Size(126, 21);
            this.pickFilm.TabIndex = 1;
            // 
            // pickCinema
            // 
            this.pickCinema.FormattingEnabled = true;
            this.pickCinema.Location = new System.Drawing.Point(574, 74);
            this.pickCinema.Name = "pickCinema";
            this.pickCinema.Size = new System.Drawing.Size(126, 21);
            this.pickCinema.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фильм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кинотеатр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата начала аренды";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата окончания аренды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Стоимость аренды";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(574, 119);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerStart.TabIndex = 9;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(574, 150);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerEnd.TabIndex = 10;
            // 
            // textPenalty
            // 
            this.textPenalty.Location = new System.Drawing.Point(574, 189);
            this.textPenalty.Name = "textPenalty";
            this.textPenalty.Size = new System.Drawing.Size(126, 20);
            this.textPenalty.TabIndex = 11;
            // 
            // textRentCost
            // 
            this.textRentCost.Location = new System.Drawing.Point(574, 228);
            this.textRentCost.Name = "textRentCost";
            this.textRentCost.Size = new System.Drawing.Size(126, 20);
            this.textRentCost.TabIndex = 12;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(682, 387);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(102, 51);
            this.button_Delete.TabIndex = 41;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(574, 387);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(102, 51);
            this.button_Update.TabIndex = 40;
            this.button_Update.Text = "Обновить информацию о аренде";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(466, 387);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(102, 51);
            this.button_Add.TabIndex = 39;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textRentCost);
            this.Controls.Add(this.textPenalty);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickCinema);
            this.Controls.Add(this.pickFilm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rental";
            this.Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox pickFilm;
        private System.Windows.Forms.ComboBox pickCinema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TextBox textPenalty;
        private System.Windows.Forms.TextBox textRentCost;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
    }
}