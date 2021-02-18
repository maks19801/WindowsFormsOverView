
namespace KeyEnterPanel
{
    partial class CardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CardNumberLbl = new System.Windows.Forms.Label();
            this.CardNumberTxt = new System.Windows.Forms.TextBox();
            this.PinContainer = new System.Windows.Forms.Panel();
            this.PinTxt = new System.Windows.Forms.TextBox();
            this.KeyBoard7Btn = new System.Windows.Forms.Button();
            this.KeyBoard0Btn = new System.Windows.Forms.Button();
            this.KeyBoard8Btn = new System.Windows.Forms.Button();
            this.KeyBoard3Btn = new System.Windows.Forms.Button();
            this.KeyBoard9Btn = new System.Windows.Forms.Button();
            this.KeyBoard2Btn = new System.Windows.Forms.Button();
            this.KeyBoard4Btn = new System.Windows.Forms.Button();
            this.KeyBoard1Btn = new System.Windows.Forms.Button();
            this.KeyBoard5Btn = new System.Windows.Forms.Button();
            this.KeyBoard6Btn = new System.Windows.Forms.Button();
            this.PinContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardNumberLbl
            // 
            this.CardNumberLbl.AutoSize = true;
            this.CardNumberLbl.Location = new System.Drawing.Point(-3, 0);
            this.CardNumberLbl.Name = "CardNumberLbl";
            this.CardNumberLbl.Size = new System.Drawing.Size(103, 20);
            this.CardNumberLbl.TabIndex = 7;
            this.CardNumberLbl.Text = "Card Number";
            // 
            // CardNumberTxt
            // 
            this.CardNumberTxt.Location = new System.Drawing.Point(0, 23);
            this.CardNumberTxt.Name = "CardNumberTxt";
            this.CardNumberTxt.ReadOnly = true;
            this.CardNumberTxt.Size = new System.Drawing.Size(163, 26);
            this.CardNumberTxt.TabIndex = 6;
            this.CardNumberTxt.TextChanged += new System.EventHandler(this.CardNumberTxt_TextChanged);
            // 
            // PinContainer
            // 
            this.PinContainer.Controls.Add(this.PinTxt);
            this.PinContainer.Controls.Add(this.KeyBoard7Btn);
            this.PinContainer.Controls.Add(this.KeyBoard0Btn);
            this.PinContainer.Controls.Add(this.KeyBoard8Btn);
            this.PinContainer.Controls.Add(this.KeyBoard3Btn);
            this.PinContainer.Controls.Add(this.KeyBoard9Btn);
            this.PinContainer.Controls.Add(this.KeyBoard2Btn);
            this.PinContainer.Controls.Add(this.KeyBoard4Btn);
            this.PinContainer.Controls.Add(this.KeyBoard1Btn);
            this.PinContainer.Controls.Add(this.KeyBoard5Btn);
            this.PinContainer.Controls.Add(this.KeyBoard6Btn);
            this.PinContainer.Location = new System.Drawing.Point(31, 72);
            this.PinContainer.Name = "PinContainer";
            this.PinContainer.Size = new System.Drawing.Size(108, 176);
            this.PinContainer.TabIndex = 5;
            // 
            // PinTxt
            // 
            this.PinTxt.Location = new System.Drawing.Point(3, 3);
            this.PinTxt.Name = "PinTxt";
            this.PinTxt.ReadOnly = true;
            this.PinTxt.Size = new System.Drawing.Size(102, 26);
            this.PinTxt.TabIndex = 1;
            this.PinTxt.TextChanged += new System.EventHandler(this.PinTxt_TextChanged);
            // 
            // KeyBoard7Btn
            // 
            this.KeyBoard7Btn.Location = new System.Drawing.Point(3, 35);
            this.KeyBoard7Btn.Name = "KeyBoard7Btn";
            this.KeyBoard7Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard7Btn.TabIndex = 0;
            this.KeyBoard7Btn.Text = "7";
            this.KeyBoard7Btn.UseVisualStyleBackColor = true;
            this.KeyBoard7Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard0Btn
            // 
            this.KeyBoard0Btn.Location = new System.Drawing.Point(39, 143);
            this.KeyBoard0Btn.Name = "KeyBoard0Btn";
            this.KeyBoard0Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard0Btn.TabIndex = 0;
            this.KeyBoard0Btn.Text = "0";
            this.KeyBoard0Btn.UseVisualStyleBackColor = true;
            this.KeyBoard0Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard8Btn
            // 
            this.KeyBoard8Btn.Location = new System.Drawing.Point(39, 35);
            this.KeyBoard8Btn.Name = "KeyBoard8Btn";
            this.KeyBoard8Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard8Btn.TabIndex = 0;
            this.KeyBoard8Btn.Text = "8";
            this.KeyBoard8Btn.UseVisualStyleBackColor = true;
            this.KeyBoard8Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard3Btn
            // 
            this.KeyBoard3Btn.Location = new System.Drawing.Point(75, 107);
            this.KeyBoard3Btn.Name = "KeyBoard3Btn";
            this.KeyBoard3Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard3Btn.TabIndex = 0;
            this.KeyBoard3Btn.Text = "3";
            this.KeyBoard3Btn.UseVisualStyleBackColor = true;
            this.KeyBoard3Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard9Btn
            // 
            this.KeyBoard9Btn.Location = new System.Drawing.Point(75, 35);
            this.KeyBoard9Btn.Name = "KeyBoard9Btn";
            this.KeyBoard9Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard9Btn.TabIndex = 0;
            this.KeyBoard9Btn.Text = "9";
            this.KeyBoard9Btn.UseVisualStyleBackColor = true;
            this.KeyBoard9Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard2Btn
            // 
            this.KeyBoard2Btn.Location = new System.Drawing.Point(39, 107);
            this.KeyBoard2Btn.Name = "KeyBoard2Btn";
            this.KeyBoard2Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard2Btn.TabIndex = 0;
            this.KeyBoard2Btn.Text = "2";
            this.KeyBoard2Btn.UseVisualStyleBackColor = true;
            this.KeyBoard2Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard4Btn
            // 
            this.KeyBoard4Btn.Location = new System.Drawing.Point(3, 71);
            this.KeyBoard4Btn.Name = "KeyBoard4Btn";
            this.KeyBoard4Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard4Btn.TabIndex = 0;
            this.KeyBoard4Btn.Text = "4";
            this.KeyBoard4Btn.UseVisualStyleBackColor = true;
            this.KeyBoard4Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard1Btn
            // 
            this.KeyBoard1Btn.Location = new System.Drawing.Point(3, 107);
            this.KeyBoard1Btn.Name = "KeyBoard1Btn";
            this.KeyBoard1Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard1Btn.TabIndex = 0;
            this.KeyBoard1Btn.Text = "1";
            this.KeyBoard1Btn.UseVisualStyleBackColor = true;
            this.KeyBoard1Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard5Btn
            // 
            this.KeyBoard5Btn.Location = new System.Drawing.Point(39, 71);
            this.KeyBoard5Btn.Name = "KeyBoard5Btn";
            this.KeyBoard5Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard5Btn.TabIndex = 0;
            this.KeyBoard5Btn.Text = "5";
            this.KeyBoard5Btn.UseVisualStyleBackColor = true;
            this.KeyBoard5Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // KeyBoard6Btn
            // 
            this.KeyBoard6Btn.Location = new System.Drawing.Point(75, 71);
            this.KeyBoard6Btn.Name = "KeyBoard6Btn";
            this.KeyBoard6Btn.Size = new System.Drawing.Size(30, 30);
            this.KeyBoard6Btn.TabIndex = 0;
            this.KeyBoard6Btn.Text = "6";
            this.KeyBoard6Btn.UseVisualStyleBackColor = true;
            this.KeyBoard6Btn.Click += new System.EventHandler(this.KeyBoardBtn_Click);
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardNumberLbl);
            this.Controls.Add(this.CardNumberTxt);
            this.Controls.Add(this.PinContainer);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(166, 250);
            this.PinContainer.ResumeLayout(false);
            this.PinContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardNumberLbl;
        private System.Windows.Forms.TextBox CardNumberTxt;
        private System.Windows.Forms.Panel PinContainer;
        private System.Windows.Forms.TextBox PinTxt;
        private System.Windows.Forms.Button KeyBoard7Btn;
        private System.Windows.Forms.Button KeyBoard0Btn;
        private System.Windows.Forms.Button KeyBoard8Btn;
        private System.Windows.Forms.Button KeyBoard3Btn;
        private System.Windows.Forms.Button KeyBoard9Btn;
        private System.Windows.Forms.Button KeyBoard2Btn;
        private System.Windows.Forms.Button KeyBoard4Btn;
        private System.Windows.Forms.Button KeyBoard1Btn;
        private System.Windows.Forms.Button KeyBoard5Btn;
        private System.Windows.Forms.Button KeyBoard6Btn;
    }
}
