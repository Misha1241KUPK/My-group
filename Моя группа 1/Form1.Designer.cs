namespace Моя_группа_1
{
    partial class Form1
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
            this.tablica = new System.Windows.Forms.DataGridView();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.familia = new System.Windows.Forms.TextBox();
            this.otch = new System.Windows.Forms.TextBox();
            this.nomer = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablica)).BeginInit();
            this.SuspendLayout();
            // 
            // tablica
            // 
            this.tablica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Имя,
            this.Фамилия,
            this.Отчество,
            this.Номер,
            this.Адрес});
            this.tablica.Location = new System.Drawing.Point(0, 0);
            this.tablica.Name = "tablica";
            this.tablica.Size = new System.Drawing.Size(545, 118);
            this.tablica.TabIndex = 0;
            this.tablica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.Name = "Имя";
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            // 
            // Отчество
            // 
            this.Отчество.HeaderText = "Отчество";
            this.Отчество.Name = "Отчество";
            // 
            // Номер
            // 
            this.Номер.HeaderText = "Номер";
            this.Номер.Name = "Номер";
            // 
            // Адрес
            // 
            this.Адрес.HeaderText = "Адрес";
            this.Адрес.Name = "Адрес";
            // 
            // dob
            // 
            this.dob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dob.Location = new System.Drawing.Point(310, 134);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(225, 49);
            this.dob.TabIndex = 1;
            this.dob.Text = "Добавить запись";
            this.dob.UseVisualStyleBackColor = false;
            this.dob.Click += new System.EventHandler(this.button1_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.del.Location = new System.Drawing.Point(310, 215);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(225, 46);
            this.del.TabIndex = 3;
            this.del.Text = "Удалить запись";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.name.Location = new System.Drawing.Point(12, 137);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(172, 20);
            this.name.TabIndex = 4;
            // 
            // familia
            // 
            this.familia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.familia.Location = new System.Drawing.Point(12, 163);
            this.familia.Name = "familia";
            this.familia.Size = new System.Drawing.Size(172, 20);
            this.familia.TabIndex = 5;
            // 
            // otch
            // 
            this.otch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.otch.Location = new System.Drawing.Point(12, 189);
            this.otch.Name = "otch";
            this.otch.Size = new System.Drawing.Size(172, 20);
            this.otch.TabIndex = 6;
            // 
            // nomer
            // 
            this.nomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nomer.Location = new System.Drawing.Point(12, 215);
            this.nomer.Name = "nomer";
            this.nomer.Size = new System.Drawing.Size(172, 20);
            this.nomer.TabIndex = 7;
            // 
            // adres
            // 
            this.adres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adres.Location = new System.Drawing.Point(12, 241);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(172, 20);
            this.adres.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Адрес";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(547, 280);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.nomer);
            this.Controls.Add(this.otch);
            this.Controls.Add(this.familia);
            this.Controls.Add(this.name);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.tablica);
            this.Name = "Form1";
            this.Text = "Моя группа";
            ((System.ComponentModel.ISupportInitialize)(this.tablica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отчество;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.Button dob;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox familia;
        private System.Windows.Forms.TextBox otch;
        private System.Windows.Forms.TextBox nomer;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

