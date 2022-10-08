namespace NaveensLateFeeCalculator
{
    partial class frmSystems
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.txtNumberofDaysLate = new System.Windows.Forms.TextBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.LateFee = new System.Windows.Forms.Label();
            this.NumberofDaysLate = new System.Windows.Forms.Label();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(711, 497);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(154, 52);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(439, 497);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 52);
            this.btnCalculate.TabIndex = 31;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtLateFee
            // 
            this.txtLateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateFee.Location = new System.Drawing.Point(565, 406);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.ReadOnly = true;
            this.txtLateFee.Size = new System.Drawing.Size(300, 27);
            this.txtLateFee.TabIndex = 30;
            // 
            // txtNumberofDaysLate
            // 
            this.txtNumberofDaysLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofDaysLate.Location = new System.Drawing.Point(565, 346);
            this.txtNumberofDaysLate.Name = "txtNumberofDaysLate";
            this.txtNumberofDaysLate.ReadOnly = true;
            this.txtNumberofDaysLate.Size = new System.Drawing.Size(300, 27);
            this.txtNumberofDaysLate.TabIndex = 29;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDate.Location = new System.Drawing.Point(565, 282);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.Size = new System.Drawing.Size(300, 27);
            this.txtCurrentDate.TabIndex = 28;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Location = new System.Drawing.Point(565, 222);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(300, 27);
            this.txtDueDate.TabIndex = 27;
            // 
            // LateFee
            // 
            this.LateFee.AutoSize = true;
            this.LateFee.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LateFee.Location = new System.Drawing.Point(342, 406);
            this.LateFee.Name = "LateFee";
            this.LateFee.Size = new System.Drawing.Size(72, 23);
            this.LateFee.TabIndex = 26;
            this.LateFee.Text = "Late Fee";
            // 
            // NumberofDaysLate
            // 
            this.NumberofDaysLate.AutoSize = true;
            this.NumberofDaysLate.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofDaysLate.Location = new System.Drawing.Point(342, 346);
            this.NumberofDaysLate.Name = "NumberofDaysLate";
            this.NumberofDaysLate.Size = new System.Drawing.Size(174, 23);
            this.NumberofDaysLate.TabIndex = 25;
            this.NumberofDaysLate.Text = "Number of Days Late";
            // 
            // CurrentDate
            // 
            this.CurrentDate.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.Location = new System.Drawing.Point(342, 282);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(149, 23);
            this.CurrentDate.TabIndex = 24;
            this.CurrentDate.Text = "Current Date";
            // 
            // DueDate
            // 
            this.DueDate.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DueDate.Location = new System.Drawing.Point(342, 223);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(161, 23);
            this.DueDate.TabIndex = 23;
            this.DueDate.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1210, 144);
            this.label1.TabIndex = 21;
            this.label1.Text = "Game Systems - $5.00 per day";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1213, 786);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.txtNumberofDaysLate);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.LateFee);
            this.Controls.Add(this.NumberofDaysLate);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSystems";
            this.Text = "frmSystems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.TextBox txtNumberofDaysLate;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label LateFee;
        private System.Windows.Forms.Label NumberofDaysLate;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Label DueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}