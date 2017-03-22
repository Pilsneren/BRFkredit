namespace BRF.View
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
            this.calculatorButton = new System.Windows.Forms.Button();
            this.talBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculatorButton
            // 
            this.calculatorButton.Location = new System.Drawing.Point(51, 114);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(161, 23);
            this.calculatorButton.TabIndex = 0;
            this.calculatorButton.Text = "Calculate!";
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // talBox
            // 
            this.talBox.Location = new System.Drawing.Point(41, 21);
            this.talBox.Name = "talBox";
            this.talBox.Size = new System.Drawing.Size(186, 20);
            this.talBox.TabIndex = 1;
            this.talBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.talBox.Click += new System.EventHandler(this.talBox_Click);
            this.talBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.talBox_KeyPress);
            // 
            // outputBox
            // 
            this.outputBox.Enabled = false;
            this.outputBox.Location = new System.Drawing.Point(41, 62);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(186, 20);
            this.outputBox.TabIndex = 2;
            this.outputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 154);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.talBox);
            this.Controls.Add(this.calculatorButton);
            this.Name = "Form1";
            this.Text = "Convert Roman to Decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculatorButton;
        private System.Windows.Forms.TextBox talBox;
        private System.Windows.Forms.TextBox outputBox;
    }
}

