namespace ChangeCalculator
{
    partial class formChangeCalculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblQuarters = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblNickels = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 208);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(190, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(2, 31);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(148, 13);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "Amount of change due (0-99):";
            // 
            // lblQuarters
            // 
            this.lblQuarters.AutoSize = true;
            this.lblQuarters.Location = new System.Drawing.Point(100, 90);
            this.lblQuarters.Name = "lblQuarters";
            this.lblQuarters.Size = new System.Drawing.Size(50, 13);
            this.lblQuarters.TabIndex = 3;
            this.lblQuarters.Text = "Quarters:";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(165, 28);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 1;
            this.txtChange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(165, 136);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.ReadOnly = true;
            this.txtNickels.Size = new System.Drawing.Size(100, 20);
            this.txtNickels.TabIndex = 5;
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(165, 83);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.ReadOnly = true;
            this.txtQuarters.Size = new System.Drawing.Size(100, 20);
            this.txtQuarters.TabIndex = 6;
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(165, 110);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.ReadOnly = true;
            this.txtDimes.Size = new System.Drawing.Size(100, 20);
            this.txtDimes.TabIndex = 7;
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(165, 163);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.ReadOnly = true;
            this.txtPennies.Size = new System.Drawing.Size(100, 20);
            this.txtPennies.TabIndex = 8;
            // 
            // lblDimes
            // 
            this.lblDimes.AutoSize = true;
            this.lblDimes.Location = new System.Drawing.Point(111, 117);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(39, 13);
            this.lblDimes.TabIndex = 9;
            this.lblDimes.Text = "Dimes:";
            // 
            // lblNickels
            // 
            this.lblNickels.AutoSize = true;
            this.lblNickels.Location = new System.Drawing.Point(105, 143);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(45, 13);
            this.lblNickels.TabIndex = 10;
            this.lblNickels.Text = "Nickels:";
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.Location = new System.Drawing.Point(102, 170);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(48, 13);
            this.lblPennies.TabIndex = 11;
            this.lblPennies.Text = "Pennies:";
            this.lblPennies.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(103, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "John Zika Lab 5";
            // 
            // formChangeCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblNickels);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblQuarters);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "formChangeCalculator";
            this.Text = "Change Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblQuarters;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Label lblDimes;
        private System.Windows.Forms.Label lblNickels;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}

