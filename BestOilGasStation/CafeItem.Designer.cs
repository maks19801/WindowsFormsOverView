
namespace BestOilGasStation
{
    partial class CafeItem
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
            this.ItemNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.ItemCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemNumericUpDown
            // 
            this.ItemNumericUpDown.Enabled = false;
            this.ItemNumericUpDown.Location = new System.Drawing.Point(259, 9);
            this.ItemNumericUpDown.Name = "ItemNumericUpDown";
            this.ItemNumericUpDown.Size = new System.Drawing.Size(102, 31);
            this.ItemNumericUpDown.TabIndex = 9;
            this.ItemNumericUpDown.ValueChanged += new System.EventHandler(this.ItemNumericUpDown_ValueChanged);
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(165, 9);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.ReadOnly = true;
            this.ItemTextBox.Size = new System.Drawing.Size(67, 31);
            this.ItemTextBox.TabIndex = 8;
            // 
            // ItemCheckBox
            // 
            this.ItemCheckBox.AutoSize = true;
            this.ItemCheckBox.Location = new System.Drawing.Point(9, 11);
            this.ItemCheckBox.Name = "ItemCheckBox";
            this.ItemCheckBox.Size = new System.Drawing.Size(150, 29);
            this.ItemCheckBox.TabIndex = 7;
            this.ItemCheckBox.Text = "ItemCheckBox";
            this.ItemCheckBox.UseVisualStyleBackColor = true;
            this.ItemCheckBox.CheckedChanged += new System.EventHandler(this.ItemCheckBox_CheckedChanged);
            // 
            // CafeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemNumericUpDown);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.ItemCheckBox);
            this.Name = "CafeItem";
            this.Size = new System.Drawing.Size(369, 47);
            ((System.ComponentModel.ISupportInitialize)(this.ItemNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ItemNumericUpDown;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.CheckBox ItemCheckBox;
    }
}
