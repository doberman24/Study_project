namespace Lab1
{
    partial class Form1
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.lB1 = new System.Windows.Forms.ListBox();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(28, 138);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(96, 40);
            this.b1.TabIndex = 0;
            this.b1.Text = "Текст 1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(161, 140);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(93, 37);
            this.b2.TabIndex = 1;
            this.b2.Text = "Скопировать";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.Location = new System.Drawing.Point(105, 9);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(84, 42);
            this.l1.TabIndex = 2;
            this.l1.Text = "label1";
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(27, 195);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(96, 35);
            this.b4.TabIndex = 3;
            this.b4.Text = "Скрыть";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(163, 190);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(90, 39);
            this.b3.TabIndex = 4;
            this.b3.Text = "Выход";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(100, 64);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(88, 20);
            this.tB1.TabIndex = 5;
            // 
            // lB1
            // 
            this.lB1.FormattingEnabled = true;
            this.lB1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lB1.Items.AddRange(new object[] {
            "Объект 1",
            "Объект 2",
            "Объект 3",
            "Объект 4",
            "Объект 5"});
            this.lB1.Location = new System.Drawing.Point(293, 40);
            this.lB1.Name = "lB1";
            this.lB1.Size = new System.Drawing.Size(196, 30);
            this.lB1.TabIndex = 6;
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Checked = true;
            this.rB1.Location = new System.Drawing.Point(13, 25);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(107, 17);
            this.rB1.TabIndex = 7;
            this.rB1.TabStop = true;
            this.rB1.Text = "Текс из TextBox";
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(13, 45);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(107, 17);
            this.rB2.TabIndex = 8;
            this.rB2.TabStop = true;
            this.rB2.Text = "Текст из ListBox";
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Location = new System.Drawing.Point(293, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 74);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Переключатели";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lB1);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        bool vis = true;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.ListBox lB1;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

