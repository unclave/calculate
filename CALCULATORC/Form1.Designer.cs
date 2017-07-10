namespace CALCULATORC
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
            this.PLUS = new System.Windows.Forms.Button();
            this.MIN = new System.Windows.Forms.Button();
            this.DIVISION = new System.Windows.Forms.Button();
            this.MULTIPLY = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PLUS
            // 
            this.PLUS.Location = new System.Drawing.Point(33, 33);
            this.PLUS.Name = "PLUS";
            this.PLUS.Size = new System.Drawing.Size(75, 23);
            this.PLUS.TabIndex = 0;
            this.PLUS.Text = "+";
            this.PLUS.UseVisualStyleBackColor = true;
            this.PLUS.Click += new System.EventHandler(this.PLUS_Click);
            // 
            // MIN
            // 
            this.MIN.Location = new System.Drawing.Point(165, 33);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(75, 23);
            this.MIN.TabIndex = 1;
            this.MIN.Text = "-";
            this.MIN.UseVisualStyleBackColor = true;
            this.MIN.Click += new System.EventHandler(this.MIN_Click);
            // 
            // DIVISION
            // 
            this.DIVISION.Location = new System.Drawing.Point(33, 82);
            this.DIVISION.Name = "DIVISION";
            this.DIVISION.Size = new System.Drawing.Size(75, 23);
            this.DIVISION.TabIndex = 2;
            this.DIVISION.Text = "/";
            this.DIVISION.UseVisualStyleBackColor = true;
            this.DIVISION.Click += new System.EventHandler(this.DIVISION_Click);
            // 
            // MULTIPLY
            // 
            this.MULTIPLY.Location = new System.Drawing.Point(165, 82);
            this.MULTIPLY.Name = "MULTIPLY";
            this.MULTIPLY.Size = new System.Drawing.Size(75, 23);
            this.MULTIPLY.TabIndex = 3;
            this.MULTIPLY.Text = "*";
            this.MULTIPLY.UseVisualStyleBackColor = true;
            this.MULTIPLY.Click += new System.EventHandler(this.MULTIPLY_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Answer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MULTIPLY);
            this.Controls.Add(this.DIVISION);
            this.Controls.Add(this.MIN);
            this.Controls.Add(this.PLUS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PLUS;
        private System.Windows.Forms.Button MIN;
        private System.Windows.Forms.Button DIVISION;
        private System.Windows.Forms.Button MULTIPLY;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

