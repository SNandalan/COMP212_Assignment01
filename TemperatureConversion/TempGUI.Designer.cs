﻿namespace TemperatureConversion
{
    partial class TempGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.FValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CelsiusValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Fahrenheit value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FValue
            // 
            this.FValue.Location = new System.Drawing.Point(43, 56);
            this.FValue.Name = "FValue";
            this.FValue.Size = new System.Drawing.Size(100, 20);
            this.FValue.TabIndex = 1;
            this.FValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Celsius: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CelsiusValue
            // 
            this.CelsiusValue.AutoSize = true;
            this.CelsiusValue.Location = new System.Drawing.Point(108, 140);
            this.CelsiusValue.Name = "CelsiusValue";
            this.CelsiusValue.Size = new System.Drawing.Size(35, 13);
            this.CelsiusValue.TabIndex = 3;
            this.CelsiusValue.Text = "label3";
            this.CelsiusValue.Click += new System.EventHandler(this.CelsiusValue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TempGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CelsiusValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FValue);
            this.Controls.Add(this.label1);
            this.Name = "TempGUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CelsiusValue;
        private System.Windows.Forms.Button button1;
    }
}

