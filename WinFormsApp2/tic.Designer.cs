﻿namespace WinFormsApp2
{
    partial class tic
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
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            AImoves = new System.Windows.Forms.Timer(components);
            button10 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(55, 50);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(129, 120);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerClick;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(190, 50);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(129, 120);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerClick;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(325, 50);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(129, 120);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerClick;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(55, 176);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(129, 120);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerClick;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(190, 176);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(129, 120);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerClick;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(325, 176);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(129, 120);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerClick;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(55, 302);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(129, 120);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerClick;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(190, 302);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(129, 120);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerClick;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(325, 302);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(129, 120);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerClick;
            // 
            // AImoves
            // 
            AImoves.Interval = 1000;
            AImoves.Tick += AImove;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(209, 428);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(94, 43);
            button10.TabIndex = 9;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Restart_game;
            // 
            // tic
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(510, 483);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "tic";
            Text = "tic";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer AImoves;
        private System.Windows.Forms.Button button10;
    }
}