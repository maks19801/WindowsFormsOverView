
namespace WindowsFormsOverView
{
    partial class MainForm
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
            this.CounterBtn = new System.Windows.Forms.Button();
            this.CounterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CounterBtn
            // 
            this.CounterBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CounterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CounterBtn.Location = new System.Drawing.Point(351, 221);
            this.CounterBtn.Name = "CounterBtn";
            this.CounterBtn.Size = new System.Drawing.Size(97, 30);
            this.CounterBtn.TabIndex = 0;
            this.CounterBtn.Text = "increment";
            this.CounterBtn.UseVisualStyleBackColor = false;
            this.CounterBtn.Click += new System.EventHandler(this.CounterBtn_Click);
            this.CounterBtn.MouseEnter += new System.EventHandler(this.CounterBtn_MouseEnter);
            this.CounterBtn.MouseLeave += new System.EventHandler(this.CounterBtn_MouseLeave);
            // 
            // CounterLbl
            // 
            this.CounterLbl.AutoSize = true;
            this.CounterLbl.Location = new System.Drawing.Point(347, 152);
            this.CounterLbl.Name = "CounterLbl";
            this.CounterLbl.Size = new System.Drawing.Size(18, 20);
            this.CounterLbl.TabIndex = 1;
            this.CounterLbl.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CounterLbl);
            this.Controls.Add(this.CounterBtn);
            this.HelpButton = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CounterBtn;
        private System.Windows.Forms.Label CounterLbl;
    }
}

