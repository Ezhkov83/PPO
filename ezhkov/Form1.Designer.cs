namespace ezhkov
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dobavitb = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dobavitb
            // 
            this.dobavitb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dobavitb.Location = new System.Drawing.Point(13, 327);
            this.dobavitb.Name = "dobavitb";
            this.dobavitb.Size = new System.Drawing.Size(139, 23);
            this.dobavitb.TabIndex = 1;
            this.dobavitb.Text = "Выбрать файл";
            this.dobavitb.UseVisualStyleBackColor = true;
            this.dobavitb.Click += new System.EventHandler(this.dobavitb_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnadd.Location = new System.Drawing.Point(12, 356);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(140, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndlt
            // 
            this.btndlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndlt.Location = new System.Drawing.Point(12, 385);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(140, 23);
            this.btndlt.TabIndex = 3;
            this.btndlt.Text = "Удалить";
            this.btndlt.UseVisualStyleBackColor = true;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.Location = new System.Drawing.Point(562, 385);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(183, 20);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cmbsearch
            // 
            this.cmbsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "Пациент",
            "Болезнь",
            "Должность врача"});
            this.cmbsearch.Location = new System.Drawing.Point(624, 345);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(121, 21);
            this.cmbsearch.TabIndex = 5;
            this.cmbsearch.Text = "Критерий поиска";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(558, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dobavitb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dobavitb;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label label1;
    }
}

