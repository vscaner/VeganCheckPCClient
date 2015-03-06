namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegetstatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.veganstatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.testinanimals = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.google = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bcod,
            this.name,
            this.companyname,
            this.vegetstatus,
            this.veganstatus,
            this.testinanimals,
            this.google,
            this.ok,
            this.del});
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Всего записей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Авторизирован как: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(146, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // bcod
            // 
            this.bcod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bcod.HeaderText = "Штрих-код";
            this.bcod.Name = "bcod";
            this.bcod.Width = 84;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            // 
            // companyname
            // 
            this.companyname.HeaderText = "Компания производитель";
            this.companyname.Name = "companyname";
            // 
            // vegetstatus
            // 
            this.vegetstatus.HeaderText = "Вегетарианский";
            this.vegetstatus.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.vegetstatus.Name = "vegetstatus";
            this.vegetstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vegetstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // veganstatus
            // 
            this.veganstatus.HeaderText = "Веганский";
            this.veganstatus.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.veganstatus.Name = "veganstatus";
            this.veganstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.veganstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // testinanimals
            // 
            this.testinanimals.HeaderText = "Тесты на животных";
            this.testinanimals.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.testinanimals.Name = "testinanimals";
            this.testinanimals.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.testinanimals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // google
            // 
            this.google.HeaderText = "";
            this.google.Name = "google";
            this.google.ReadOnly = true;
            this.google.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.google.Text = "Искать";
            this.google.ToolTipText = "Искать";
            // 
            // ok
            // 
            this.ok.HeaderText = "";
            this.ok.Name = "ok";
            this.ok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // del
            // 
            this.del.HeaderText = "";
            this.del.Name = "del";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Модерация";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcod;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyname;
        private System.Windows.Forms.DataGridViewComboBoxColumn vegetstatus;
        private System.Windows.Forms.DataGridViewComboBoxColumn veganstatus;
        private System.Windows.Forms.DataGridViewComboBoxColumn testinanimals;
        private System.Windows.Forms.DataGridViewButtonColumn google;
        private System.Windows.Forms.DataGridViewButtonColumn ok;
        private System.Windows.Forms.DataGridViewButtonColumn del;
    }
}