﻿
namespace KeyEnterPanel
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
            this.CardControl = new KeyEnterPanel.CardControl();
            this.SuspendLayout();
            // 
            // CardControl
            // 
            this.CardControl.Location = new System.Drawing.Point(301, 62);
            this.CardControl.Name = "CardControl";
            this.CardControl.Size = new System.Drawing.Size(166, 250);
            this.CardControl.TabIndex = 11;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CardControl);
            this.Name = "Form1";
            this.Text = "PinEnterKeyBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private CardControl CardControl;
    }
}

