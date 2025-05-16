namespace WindowsFormsApp1.Forms
{
    partial class FilmForm
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
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Script = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textReleaseYear = new System.Windows.Forms.TextBox();
            this.textProducer = new System.Windows.Forms.TextBox();
            this.textStageDirector = new System.Windows.Forms.TextBox();
            this.textScriptWriter = new System.Windows.Forms.TextBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmName,
            this.Genr,
            this.Script,
            this.Produce,
            this.Prod,
            this.Year,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // FilmName
            // 
            this.FilmName.HeaderText = "Название фильма";
            this.FilmName.Name = "FilmName";
            // 
            // Genr
            // 
            this.Genr.HeaderText = "Жанр";
            this.Genr.Name = "Genr";
            // 
            // Script
            // 
            this.Script.HeaderText = "Автор сценария";
            this.Script.Name = "Script";
            // 
            // Produce
            // 
            this.Produce.HeaderText = "Режисер постановщик";
            this.Produce.Name = "Produce";
            // 
            // Prod
            // 
            this.Prod.HeaderText = "Продюсер";
            this.Prod.Name = "Prod";
            // 
            // Year
            // 
            this.Year.HeaderText = "Год выпуска фидьма";
            this.Year.Name = "Year";
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость фильма";
            this.cost.Name = "cost";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(1027, 387);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(102, 51);
            this.button_Delete.TabIndex = 38;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(919, 387);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(102, 51);
            this.button_Update.TabIndex = 37;
            this.button_Update.Text = "Обновить информацию о кинотеатре";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(811, 387);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(102, 51);
            this.button_Add.TabIndex = 36;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(842, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Год выпуска фильма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(894, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Продюсер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Режиссер-постановщик";
            // 
            // textReleaseYear
            // 
            this.textReleaseYear.Location = new System.Drawing.Point(959, 256);
            this.textReleaseYear.Name = "textReleaseYear";
            this.textReleaseYear.Size = new System.Drawing.Size(144, 20);
            this.textReleaseYear.TabIndex = 28;
            // 
            // textProducer
            // 
            this.textProducer.Location = new System.Drawing.Point(959, 207);
            this.textProducer.Name = "textProducer";
            this.textProducer.Size = new System.Drawing.Size(144, 20);
            this.textProducer.TabIndex = 27;
            // 
            // textStageDirector
            // 
            this.textStageDirector.Location = new System.Drawing.Point(959, 161);
            this.textStageDirector.Name = "textStageDirector";
            this.textStageDirector.Size = new System.Drawing.Size(144, 20);
            this.textStageDirector.TabIndex = 26;
            // 
            // textScriptWriter
            // 
            this.textScriptWriter.Location = new System.Drawing.Point(959, 108);
            this.textScriptWriter.Name = "textScriptWriter";
            this.textScriptWriter.Size = new System.Drawing.Size(144, 20);
            this.textScriptWriter.TabIndex = 25;
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(959, 60);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(144, 20);
            this.textGenre.TabIndex = 24;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(959, 23);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(144, 20);
            this.textName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Автор сценария";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(917, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Жанр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Название фильма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(848, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Стоимость фильма";
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(959, 304);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(144, 20);
            this.textCost.TabIndex = 39;
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textReleaseYear);
            this.Controls.Add(this.textProducer);
            this.Controls.Add(this.textStageDirector);
            this.Controls.Add(this.textScriptWriter);
            this.Controls.Add(this.textGenre);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FilmForm";
            this.Text = "FilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textReleaseYear;
        private System.Windows.Forms.TextBox textProducer;
        private System.Windows.Forms.TextBox textStageDirector;
        private System.Windows.Forms.TextBox textScriptWriter;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Script;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
    }
}