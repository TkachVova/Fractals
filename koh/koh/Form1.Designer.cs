namespace koh
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
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawTriangleButton = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mendelbrotButton = new System.Windows.Forms.Button();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw Koh *";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DrawKoh);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Lime;
            this.maskedTextBox1.Location = new System.Drawing.Point(99, 29);
            this.maskedTextBox1.Mask = "0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(20, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(99, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "number of iterations";
            // 
            // DrawTriangleButton
            // 
            this.DrawTriangleButton.BackColor = System.Drawing.Color.Lime;
            this.DrawTriangleButton.Location = new System.Drawing.Point(12, 57);
            this.DrawTriangleButton.Name = "DrawTriangleButton";
            this.DrawTriangleButton.Size = new System.Drawing.Size(81, 26);
            this.DrawTriangleButton.TabIndex = 3;
            this.DrawTriangleButton.Text = "Draw Triange";
            this.DrawTriangleButton.UseVisualStyleBackColor = false;
            this.DrawTriangleButton.Click += new System.EventHandler(this.DrawTriangleButton_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.Lime;
            this.maskedTextBox2.Location = new System.Drawing.Point(99, 61);
            this.maskedTextBox2.Mask = "0";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(20, 20);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // mendelbrotButton
            // 
            this.mendelbrotButton.BackColor = System.Drawing.Color.Lime;
            this.mendelbrotButton.Location = new System.Drawing.Point(12, 89);
            this.mendelbrotButton.Name = "mendelbrotButton";
            this.mendelbrotButton.Size = new System.Drawing.Size(81, 35);
            this.mendelbrotButton.TabIndex = 5;
            this.mendelbrotButton.Text = "Draw Mendelborot";
            this.mendelbrotButton.UseVisualStyleBackColor = false;
            this.mendelbrotButton.Click += new System.EventHandler(this.mendelbrotButton_Click);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.Lime;
            this.maskedTextBox3.Location = new System.Drawing.Point(99, 97);
            this.maskedTextBox3.Mask = "00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(20, 20);
            this.maskedTextBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 473);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.mendelbrotButton);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.DrawTriangleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Fractals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DrawTriangleButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button mendelbrotButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}

