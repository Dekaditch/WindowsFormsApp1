namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PurchaseFormButton = new System.Windows.Forms.Button();
            this.CinemaFormButton = new System.Windows.Forms.Button();
            this.RentalFormButton = new System.Windows.Forms.Button();
            this.SuppliersFormButton = new System.Windows.Forms.Button();
            this.FilmFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PurchaseFormButton
            // 
            this.PurchaseFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PurchaseFormButton.Location = new System.Drawing.Point(48, 254);
            this.PurchaseFormButton.Name = "PurchaseFormButton";
            this.PurchaseFormButton.Size = new System.Drawing.Size(124, 76);
            this.PurchaseFormButton.TabIndex = 1;
            this.PurchaseFormButton.Text = "Покупки";
            this.PurchaseFormButton.UseVisualStyleBackColor = true;
            this.PurchaseFormButton.Click += new System.EventHandler(this.PurchaseFormButton_Click);
            // 
            // CinemaFormButton
            // 
            this.CinemaFormButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.CinemaFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinemaFormButton.Location = new System.Drawing.Point(116, 90);
            this.CinemaFormButton.Name = "CinemaFormButton";
            this.CinemaFormButton.Size = new System.Drawing.Size(124, 76);
            this.CinemaFormButton.TabIndex = 2;
            this.CinemaFormButton.Text = "Кинотеатры";
            this.CinemaFormButton.UseVisualStyleBackColor = true;
            this.CinemaFormButton.Click += new System.EventHandler(this.CinemaFormButton_Click);
            // 
            // RentalFormButton
            // 
            this.RentalFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RentalFormButton.Location = new System.Drawing.Point(178, 254);
            this.RentalFormButton.Name = "RentalFormButton";
            this.RentalFormButton.Size = new System.Drawing.Size(124, 76);
            this.RentalFormButton.TabIndex = 3;
            this.RentalFormButton.Text = "Аренда";
            this.RentalFormButton.UseVisualStyleBackColor = true;
            this.RentalFormButton.Click += new System.EventHandler(this.RentalFormButton_Click);
            // 
            // SuppliersFormButton
            // 
            this.SuppliersFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuppliersFormButton.Location = new System.Drawing.Point(178, 172);
            this.SuppliersFormButton.Name = "SuppliersFormButton";
            this.SuppliersFormButton.Size = new System.Drawing.Size(124, 76);
            this.SuppliersFormButton.TabIndex = 4;
            this.SuppliersFormButton.Text = "Поставщики";
            this.SuppliersFormButton.UseVisualStyleBackColor = true;
            this.SuppliersFormButton.Click += new System.EventHandler(this.SuppliersFormButton_Click);
            // 
            // FilmFormButton
            // 
            this.FilmFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmFormButton.Location = new System.Drawing.Point(48, 172);
            this.FilmFormButton.Name = "FilmFormButton";
            this.FilmFormButton.Size = new System.Drawing.Size(124, 76);
            this.FilmFormButton.TabIndex = 5;
            this.FilmFormButton.Text = "Фильмы";
            this.FilmFormButton.UseVisualStyleBackColor = true;
            this.FilmFormButton.Click += new System.EventHandler(this.FilmFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 377);
            this.Controls.Add(this.FilmFormButton);
            this.Controls.Add(this.SuppliersFormButton);
            this.Controls.Add(this.RentalFormButton);
            this.Controls.Add(this.CinemaFormButton);
            this.Controls.Add(this.PurchaseFormButton);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PurchaseFormButton;
        private System.Windows.Forms.Button CinemaFormButton;
        private System.Windows.Forms.Button RentalFormButton;
        private System.Windows.Forms.Button SuppliersFormButton;
        private System.Windows.Forms.Button FilmFormButton;
    }
}

