﻿namespace Kalkulator
{
    partial class Form1
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.ExpPowX = new System.Windows.Forms.Button();
            this.TenPowX = new System.Windows.Forms.Button();
            this.XpowY = new System.Windows.Forms.Button();
            this.XpowOneDevY = new System.Windows.Forms.Button();
            this.LogXfromY = new System.Windows.Forms.Button();
            this.MinXY = new System.Windows.Forms.Button();
            this.MaxXY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 12);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(154, 20);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(12, 38);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(154, 20);
            this.input2.TabIndex = 1;
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(12, 110);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(75, 23);
            this.Sum.TabIndex = 2;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Button_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(93, 110);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(75, 23);
            this.Min.TabIndex = 3;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Button_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(12, 139);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(75, 23);
            this.Mul.TabIndex = 4;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Button_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(93, 139);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 5;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Button_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(12, 75);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 13);
            this.Answer.TabIndex = 6;
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(12, 168);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 7;
            this.Sin.Text = "Sin(x)";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(92, 167);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 8;
            this.Cos.Text = "Cos(x)";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(173, 168);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(75, 23);
            this.Tan.TabIndex = 9;
            this.Tan.Text = "Tan(x)";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // ExpPowX
            // 
            this.ExpPowX.Location = new System.Drawing.Point(91, 197);
            this.ExpPowX.Name = "ExpPowX";
            this.ExpPowX.Size = new System.Drawing.Size(75, 23);
            this.ExpPowX.TabIndex = 10;
            this.ExpPowX.Text = "e^x";
            this.ExpPowX.UseVisualStyleBackColor = true;
            this.ExpPowX.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // TenPowX
            // 
            this.TenPowX.Location = new System.Drawing.Point(12, 197);
            this.TenPowX.Name = "TenPowX";
            this.TenPowX.Size = new System.Drawing.Size(75, 23);
            this.TenPowX.TabIndex = 11;
            this.TenPowX.Text = "10^x";
            this.TenPowX.UseVisualStyleBackColor = true;
            this.TenPowX.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // XpowY
            // 
            this.XpowY.Location = new System.Drawing.Point(173, 226);
            this.XpowY.Name = "XpowY";
            this.XpowY.Size = new System.Drawing.Size(75, 23);
            this.XpowY.TabIndex = 12;
            this.XpowY.Text = "x^y";
            this.XpowY.UseVisualStyleBackColor = true;
            this.XpowY.Click += new System.EventHandler(this.Button_Click);
            // 
            // XpowOneDevY
            // 
            this.XpowOneDevY.Location = new System.Drawing.Point(12, 226);
            this.XpowOneDevY.Name = "XpowOneDevY";
            this.XpowOneDevY.Size = new System.Drawing.Size(75, 23);
            this.XpowOneDevY.TabIndex = 13;
            this.XpowOneDevY.Text = "x^(1/y)";
            this.XpowOneDevY.UseVisualStyleBackColor = true;
            this.XpowOneDevY.Click += new System.EventHandler(this.Button_Click);
            // 
            // LogXfromY
            // 
            this.LogXfromY.Location = new System.Drawing.Point(93, 226);
            this.LogXfromY.Name = "LogXfromY";
            this.LogXfromY.Size = new System.Drawing.Size(75, 23);
            this.LogXfromY.TabIndex = 14;
            this.LogXfromY.Text = "logx(y)\'";
            this.LogXfromY.UseVisualStyleBackColor = true;
            this.LogXfromY.Click += new System.EventHandler(this.Button_Click);
            // 
            // MinXY
            // 
            this.MinXY.Location = new System.Drawing.Point(12, 255);
            this.MinXY.Name = "MinXY";
            this.MinXY.Size = new System.Drawing.Size(75, 23);
            this.MinXY.TabIndex = 15;
            this.MinXY.Text = "Min(x,y)";
            this.MinXY.UseVisualStyleBackColor = true;
            this.MinXY.Click += new System.EventHandler(this.Button_Click);
            // 
            // MaxXY
            // 
            this.MaxXY.Location = new System.Drawing.Point(93, 255);
            this.MaxXY.Name = "MaxXY";
            this.MaxXY.Size = new System.Drawing.Size(75, 23);
            this.MaxXY.TabIndex = 16;
            this.MaxXY.Text = "Max(x,y)";
            this.MaxXY.UseVisualStyleBackColor = true;
            this.MaxXY.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 391);
            this.Controls.Add(this.MaxXY);
            this.Controls.Add(this.MinXY);
            this.Controls.Add(this.LogXfromY);
            this.Controls.Add(this.XpowOneDevY);
            this.Controls.Add(this.XpowY);
            this.Controls.Add(this.TenPowX);
            this.Controls.Add(this.ExpPowX);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Kalkulatorvor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button ExpPowX;
        private System.Windows.Forms.Button TenPowX;
        private System.Windows.Forms.Button XpowY;
        private System.Windows.Forms.Button XpowOneDevY;
        private System.Windows.Forms.Button LogXfromY;
        private System.Windows.Forms.Button MinXY;
        private System.Windows.Forms.Button MaxXY;
    }
}

