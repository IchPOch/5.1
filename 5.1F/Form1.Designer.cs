﻿namespace _5._1F
{
    partial class s
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Жми";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите A";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(12, 29);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 2;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(12, 80);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 3;
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(15, 134);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(100, 20);
            this.H.TabIndex = 4;
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(154, 12);
            this.V.Multiline = true;
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(253, 142);
            this.V.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите H";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.V);
            this.Controls.Add(this.H);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "s";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

