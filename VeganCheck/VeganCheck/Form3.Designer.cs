namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.neveg_cb = new System.Windows.Forms.CheckBox();
            this.veget_cb = new System.Windows.Forms.CheckBox();
            this.vegan_cb = new System.Windows.Forms.CheckBox();
            this.test_in_animals_cb = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.d6zb9CoMNCU1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // neveg_cb
            // 
            this.neveg_cb.AutoSize = true;
            this.neveg_cb.Location = new System.Drawing.Point(45, 362);
            this.neveg_cb.Name = "neveg_cb";
            this.neveg_cb.Size = new System.Drawing.Size(15, 14);
            this.neveg_cb.TabIndex = 1;
            this.neveg_cb.UseVisualStyleBackColor = true;
            this.neveg_cb.CheckedChanged += new System.EventHandler(this.neveg_cb_CheckedChanged);
            // 
            // veget_cb
            // 
            this.veget_cb.AutoSize = true;
            this.veget_cb.Location = new System.Drawing.Point(173, 362);
            this.veget_cb.Name = "veget_cb";
            this.veget_cb.Size = new System.Drawing.Size(15, 14);
            this.veget_cb.TabIndex = 2;
            this.veget_cb.UseVisualStyleBackColor = true;
            this.veget_cb.CheckedChanged += new System.EventHandler(this.veget_cb_CheckedChanged);
            // 
            // vegan_cb
            // 
            this.vegan_cb.AutoSize = true;
            this.vegan_cb.Location = new System.Drawing.Point(296, 362);
            this.vegan_cb.Name = "vegan_cb";
            this.vegan_cb.Size = new System.Drawing.Size(15, 14);
            this.vegan_cb.TabIndex = 3;
            this.vegan_cb.UseVisualStyleBackColor = true;
            this.vegan_cb.CheckedChanged += new System.EventHandler(this.vegan_cb_CheckedChanged);
            // 
            // test_in_animals_cb
            // 
            this.test_in_animals_cb.AutoSize = true;
            this.test_in_animals_cb.Location = new System.Drawing.Point(74, 408);
            this.test_in_animals_cb.Name = "test_in_animals_cb";
            this.test_in_animals_cb.Size = new System.Drawing.Size(15, 14);
            this.test_in_animals_cb.TabIndex = 4;
            this.test_in_animals_cb.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(29, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 17);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Имя продукта";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(29, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 17);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Производитель";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(115, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Опубликовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.test_in_animals_cb);
            this.Controls.Add(this.vegan_cb);
            this.Controls.Add(this.veget_cb);
            this.Controls.Add(this.neveg_cb);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Добавление нового продукта";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox neveg_cb;
        private System.Windows.Forms.CheckBox veget_cb;
        private System.Windows.Forms.CheckBox vegan_cb;
        private System.Windows.Forms.CheckBox test_in_animals_cb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}