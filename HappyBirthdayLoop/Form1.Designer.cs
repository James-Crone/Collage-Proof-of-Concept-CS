﻿
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.enternumLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(84, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Happy Birthday Generator";
            // 
            // enternumLabel
            // 
            this.enternumLabel.AutoSize = true;
            this.enternumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enternumLabel.Location = new System.Drawing.Point(68, 60);
            this.enternumLabel.Name = "enternumLabel";
            this.enternumLabel.Size = new System.Drawing.Size(250, 16);
            this.enternumLabel.TabIndex = 1;
            this.enternumLabel.Text = "Please enter a number between 1 and 10";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(71, 113);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(79, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(185, 116);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(133, 20);
            this.numberTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "_____________________________________";
            // 
            // printTextbox
            // 
            this.printTextbox.Location = new System.Drawing.Point(16, 181);
            this.printTextbox.Multiline = true;
            this.printTextbox.Name = "printTextbox";
            this.printTextbox.Size = new System.Drawing.Size(375, 183);
            this.printTextbox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.printTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextbox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.enternumLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label enternumLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox numberTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox printTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

